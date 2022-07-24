using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMethods : MonoBehaviour
{
    Vector3 _myPosition = new Vector3(5.145f,5f,4f);
    public Transform Watcher;
    //Altda yazilan Lerp Ucundur 
    private float _startTime;
    void Start()
    {
        #region Set
        //Geriye Void Qaytarir 1Vectorun Icine Deyer gondermek ucun mezerde tutulub
        //VectorSetMethod
        //_myPosition.Set(5f, 3f, 4f);
        //transform.position = _myPosition;
        #endregion
        #region ToString
        //Vectorun Stringe cevirir Ve verilmis deyeri yuvarlaqlasdiraraq qaytarir

        //string myposition = _myPosition.ToString();
        //print(myposition);
        #endregion
        #region Equal 
        //Icerisine deyerler gonderib sorgu aparmaq ucundur

        //VectorEquealMethod
        //if (_myPosition.Equals(new Vector3(0,0,0)))
        //{
        //    print("true");
        //}

        #endregion
        #region Time
        //Time.time (Oyun start olunduqdan sonraki zamani verir)
        //Time.deltaTime (Het Iframe gore isleyir (kare hizi )) oyunun size verdiyi FPS esasinda isleyir yazilmalidir 
        //Time.timeScale (oyun ici suretdir) default 1 dir 
        #endregion
        #region Max/Min
        Vector3 firstPos = new Vector3(1f, 2f, 3f);
        Vector3 secondPos = new Vector3(3f, 4f, 5f);
        print(Vector3.Max(firstPos, secondPos));
        print(Vector3.Min(firstPos, secondPos));
        #endregion
        #region Scale
        //Scale Methodu 2 Vectorun Hasilini Tapir
        //print(Vector3.Scale(_myPosition, transform.position));
        #endregion
        #region Vurma Bolme Cixma Toplama
        //print(_myPosition - transform.position);
        //print(_myPosition + transform.position);

        //Bir vectoru bir vectora bole ve ya vura bilmerem mentiq olaraq sehvdir float deyer vermeliyem 
        //print(_myPosition * transform.position);
        //print(_myPosition / transform.position);

        #endregion

        #region Lerp`e aiddir 
        _startTime = Time.time;
        #endregion
    }

    void Update()
    {
        #region Angle
        //Verilmis 2 Hedef arasindaki  mesafeni Derece olaraq bize qaytarir
        // angle 
        //Vector3 mesafe = Watcher.position -  transform.position;
        // float angle = Vector3.Angle(mesafe, transform.right);
        //print(angle);
        #endregion
        #region Distance
        //2 vector arasindaki mesafeni qaytarir
        //float distance = Vector3.Distance(_myPosition, Watcher.position);
        //print(distance);
        #endregion
        #region Lerp
        //2 Vector Arasinda Duz xett cekmek ucundur (Gorunmez) Meselen bir obyekti o birisine hereket ettirmek ucundur
        // transform.position = Vector3.Lerp(transform.position, Watcher.position, (Time.time - _startTime) * 0.02f);

        #endregion
    }
    #region FixedUpdate
    //private void FixedUpdate()
    //{
    //    Time.timeScale = .4f;
    //    transform.position = Vector3.Lerp(transform.position, Watcher.position, (Time.time - _startTime) * 0.02f);

    //}
    #endregion

}
