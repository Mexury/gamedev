using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private new Camera camera;
    public PolygonCollider2D polygonCollider;
    public GameObject fishPrefab;
    public float fishCaptured = 0;
    public TextMeshProUGUI textMeshProUGUI;

    void Start()
    {
        camera = Camera.main;
        StartCoroutine(SpawnBase());
        //Spawn();
    }

    public IEnumerator SpawnBase()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector2 lastPoint = Vector2.zero;
            Vector3 rndPoint3D = RandomPointInBounds(polygonCollider.bounds, 1f);
            Vector2 rndPoint2D = new Vector2(rndPoint3D.x, rndPoint3D.y);
            Vector2 rndPointInside = polygonCollider.ClosestPoint(new Vector2(rndPoint2D.x, rndPoint2D.y));
            if (rndPointInside.x == rndPoint2D.x && rndPointInside.y == rndPoint2D.y)
            {
                if (Vector2.Distance(lastPoint, rndPoint2D) > 1f)
                {
                    float scale = Random.Range(0.3f, 0.8f);
                    GameObject fish = Instantiate(fishPrefab);
                    fish.transform.rotation = new Quaternion(0, 0, Random.rotation.z, Random.rotation.w);
                    fish.transform.position = rndPoint2D;
                    fish.transform.localScale = new Vector3(scale, scale, 1);
                    lastPoint = rndPoint2D;
                }
            }
            else
            {
                i--;
            }
            yield return new WaitForSeconds(.5f);
        }
    }

    public void Spawn()
    {
        Vector2 lastPoint = Vector2.zero;
        Vector3 rndPoint3D = RandomPointInBounds(polygonCollider.bounds, 1f);
        Vector2 rndPoint2D = new Vector2(rndPoint3D.x, rndPoint3D.y);
        Vector2 rndPointInside = polygonCollider.ClosestPoint(new Vector2(rndPoint2D.x, rndPoint2D.y));
        if (rndPointInside.x == rndPoint2D.x && rndPointInside.y == rndPoint2D.y)
        {
            float scale = Random.Range(0.3f, 0.8f);
            GameObject fish = Instantiate(fishPrefab);
            fish.transform.rotation = new Quaternion(0, 0, Random.rotation.z, Random.rotation.w);
            fish.transform.position = new Vector2(rndPoint2D.x + Random.Range(-4f, 4f), rndPoint2D.y + Random.Range(-1f, 1f));
            fish.transform.localScale = new Vector3(scale, scale, 1);
            lastPoint = rndPoint2D;
        }

        fishCaptured++;
        textMeshProUGUI.text = $"{fishCaptured}";
    }

    private Vector3 RandomPointInBounds(Bounds bounds, float scale)
    {
        return new Vector3(
            Random.Range(bounds.min.x * scale, bounds.max.x * scale),
            Random.Range(bounds.min.y * scale, bounds.max.y * scale),
            Random.Range(bounds.min.z * scale, bounds.max.z * scale)
        );
    }
}
