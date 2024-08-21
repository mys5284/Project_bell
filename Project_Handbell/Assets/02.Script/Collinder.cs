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

    //���� �� ����Ʈ ȿ��
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
            else if ((dist < 1 && dist >= 0.5f) || (dist > -1 && dist <= -0.5f)) //GOOD�� �Ÿ���
            {

                //é��1 �� ���� +1��
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
            else if ((dist < 0.5f && dist >= 0.2f) || (dist > -0.5f && dist <= -0.2f)) //COOL�� �Ÿ���
            {

                //é��1 �� ���� +2��
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
            else if ((dist < 0.2f && dist >= 0f) || (dist > -0.2f && dist <= -0f)) //PERFECT�� �Ÿ���
            {

                //é��1 �� ���� +3��
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

    private void Off_Verdict() //VERDICT_IMG �ױװ� ���� ��� ��Ȱ��
    {
        GameObject[] off = GameObject.FindGameObjectsWithTag("VERDICT_IMG");

        foreach (GameObject o in off) { o.SetActive(false); }
    }

    public IEnumerator DispJud(GameObject _go) //�ش�� ���� �̹����� Ȱ��
    {
        Off_Verdict();

        Verdict_Img = _go;
        Verdict_Img.gameObject.SetActive(false);

        Verdict_Img.gameObject.SetActive(true);

        yield return null;

    }
}
