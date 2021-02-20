using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    void OnCollisionEnter(Collision myCollision)
    {
        // определение столкновения с двумя разноименными объектами
        if (myCollision.gameObject.name == "Zemlya")
        {
            // Обращаемся к имени объекта, с которым столкнулись
            Debug.Log("Stolknulsya s Zemlei");
            Debug.Log(myCollision.gameObject.name.IndexOf("Stena"));
        }
        else if (myCollision.gameObject.name.IndexOf("Stena") >= 0)
        {
            Debug.Log("Stolknulsya sо Stenoi ");
            Destroy(myCollision.gameObject);
        }
    }
}
