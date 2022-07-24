using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransFormMethods : MonoBehaviour
{
    //public Transform Watcher; 
    public GameObject Child;
    public Transform Parent; 


    void Start()
    {
        #region Rotate`e aiddir
        //transform.Rotate(90f, 0f, 0f, Space.Self);
        //Watcher.transform.Rotate(90f, 0f, 0f, Space.World);
        #endregion
        #region Find
        //Obyekt Axtarmaq ucun method
        //GameObject game = transform.Find("Bos1").gameObject;
        //print(game.name);

        //Obyektin icinde obyekt varsa 
        //GameObject game = transform.Find("Bos1/Bos1.1").gameObject;
        //print(game.name);
        #endregion
        #region ChildCount/hierarchyCount
        //icresinde nece obyekt var gorunur 
        //print(transform.childCount);

        //Obyekt qarisiq hamisini gosterir
        //print(transform.hierarchyCount)
        #endregion
        #region GetChild
        // Icrerisindeki butun yetm yesir e ulas
        //for (int i = 0; i < transform.childCount; i++)
        //{
        //    print(transform.GetChild(i));
        //}
        #endregion
        #region SetParent
        // bir birleri ile parent child elaqesi qurmaq // Position 0 layir 
        //Child.transform.SetParent(Parent);
        
        //Position 0 lamir 
       // Child.transform.SetParent(Parent,false);
        #endregion

    }

    void Update()
    {
        #region Translate
        //Davamli olaraq hereket ettirmek ucundur 
        //transform.Translate(new Vector3(0, 0, 5)*Time.deltaTime * 1f);
        //transform.forward (Ireli Getmek Ucundur)
        //transform.right Saga
        //transform.up Yuxari
        #endregion
        #region Rotate 
        //Verdiyimiz koordinatlar esasinda donur Oz etrafinda
        //transform.Rotate(new Vector3(1f, 2f, 3f) *Time.deltaTime *10f);

        //Space.Self Oz etrafinda Space.World Dunya etarafinda firlanma sureti 
        //transform.Rotate(1f, 2f, 3f, Space.Self);
        //Watcher.transform.Rotate(1f, 2f, 3f, Space.World);

        #endregion
        #region LookAt
        //1 Obyektin o birisini Izlemesi 
        //Watcher.LookAt(transform.position);
       // Watcher.LookAt(transform.position, Vector3.left);
        #endregion


    }
}
