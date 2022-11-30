using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    //public PolygonCollider2D polygonCollider;
    //public GameObject fishPrefab;
    //public int numberRandomPositions = 10;

    //void Start()
    //{
    //    if (polygonCollider == null) GetComponent<PolygonCollider2D>();
    //    if (polygonCollider == null) Debug.Log("Please assign PolygonCollider2D component.");

    //    StartCoroutine(Spawn());
    //}

    //IEnumerator Spawn()
    //{
    //    Vector2 lastPoint = Vector2.zero;
    //    for (int i = 0; i < numberRandomPositions; i++)
    //    {
    //        Vector3 rndPoint3D = RandomPointInBounds(polygonCollider.bounds, 1f);
    //        Vector2 rndPoint2D = new Vector2(rndPoint3D.x, rndPoint3D.y);
    //        Vector2 rndPointInside = polygonCollider.ClosestPoint(new Vector2(rndPoint2D.x, rndPoint2D.y));
    //        if (rndPointInside.x == rndPoint2D.x && rndPointInside.y == rndPoint2D.y)
    //        {
    //            if (Vector2.Distance(lastPoint, rndPoint2D) > 1f)
    //            {
    //                float scale = Random.Range(0.3f, 0.8f);
    //                GameObject fish = Instantiate(fishPrefab);
    //                fish.transform.rotation = new Quaternion(0, 0, Random.rotation.z, Random.rotation.w);
    //                fish.transform.position = rndPoint2D;
    //                fish.transform.localScale = new Vector3(scale, scale, 1);
    //                lastPoint = rndPoint2D;
    //            }
    //        } else
    //        {
    //            i--;
    //        }
    //        yield return new WaitForSeconds(.5f);
    //    }
    //}

    //private Vector3 RandomPointInBounds(Bounds bounds, float scale)
    //{
    //    return new Vector3(
    //        Random.Range(bounds.min.x * scale, bounds.max.x * scale),
    //        Random.Range(bounds.min.y * scale, bounds.max.y * scale),
    //        Random.Range(bounds.min.z * scale, bounds.max.z * scale)
    //    );
    //}
}
