using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Collinder : MonoBehaviour
{
    Note note;
    Transform tr;
    float dist = 0;

    GameManager gameManager;
    ScoreManager scoreManager;
    UIManager uiManager;

    //판정 시 이펙트 효과
    public ParticleSystem perfect_ef;
    public ParticleSystem cool_ef;
    public ParticleSystem good_ef;

    GameObject Verdict_Img = null;

    [SerializeField]
    public List<GameObject> jImgList = new List<GameObject>();


    private void Start()
    {
        tr = GetComponent<Transform>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NOTE"))
        {
            dist = this.tr.position.y - other.transform.position.y;

            if (dist >= 1 || dist <= -1)
            {
                StartCoroutine(DispJud(jImgList[0]));
                other.gameObject.tag = "NOTNOTE";
            }
            else if ((dist < 1 && dist >= 0.5f) || (dist > -1 && dist <= -0.5f)) //GOOD의 거리값
            {

                //챕터1 곡 별로 +1점
                if (gameManager.chapter1 == GameManager.Chapter1.song1)
                {
                    scoreManager.song1_score++;
                }
                else if (gameManager.chapter1 == GameManager.Chapter1.song2)
                {
                    scoreManager.song2_score++;
                }
                else if (gameManager.chapter1 == GameManager.Chapter1.song3)
                {
                    scoreManager.song3_score++;
                }
                Instantiate(good_ef, this.transform);
                StartCoroutine(DispJud(jImgList[1]));
                Destroy(other.gameObject);
            }
            else if ((dist < 0.5f && dist >= 0.2f) || (dist > -0.5f && dist <= -0.2f)) //COOL의 거리값
            {

                //챕터1 곡 별로 +2점
                if (gameManager.chapter1 == GameManager.Chapter1.song1)
                {
                    scoreManager.song1_score += 2;
                }
                else if (gameManager.chapter1 == GameManager.Chapter1.song2)
                {
                    scoreManager.song2_score += 2;
                }
                else if (gameManager.chapter1 == GameManager.Chapter1.song3)
                {
                    scoreManager.song3_score += 2;
                }
                Instantiate(cool_ef, this.transform);
                StartCoroutine(DispJud(jImgList[2]));
                Destroy(other.gameObject);
            }
            else if ((dist < 0.2f && dist >= 0f) || (dist > -0.2f && dist <= -0f)) //PERFECT의 거리값
            {

                //챕터1 곡 별로 +3점
                if (gameManager.chapter1 == GameManager.Chapter1.song1)
                {
                    scoreManager.song1_score += 3;
                }
                else if (gameManager.chapter1 == GameManager.Chapter1.song2)
                {
                    scoreManager.song2_score += 3;
                }
                else if (gameManager.chapter1 == GameManager.Chapter1.song3)
                {
                    scoreManager.song3_score += 3;
                }
                Instantiate(perfect_ef, this.transform);
                StartCoroutine(DispJud(jImgList[3]));
                Destroy(other.gameObject);
            }



        }
    }

    private void Off_Verdict() //VERDICT_IMG 테그가 들어간거 모두 비활성
    {
        GameObject[] off = GameObject.FindGameObjectsWithTag("VERDICT_IMG");

        foreach (GameObject o in off) { o.SetActive(false); }
    }

    public IEnumerator DispJud(GameObject _go) //해당된 판정 이미지만 활성
    {
        Off_Verdict();

        Verdict_Img = _go;
        Verdict_Img.gameObject.SetActive(false);

        Verdict_Img.gameObject.SetActive(true);

        yield return null;

    }
}
