using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionMethods : MonoBehaviour
{
    public Transform Hedef1;
    void Start()
    {
        #region
        /*Acilar rotation zamani acilar arasinda ust uste minmeler yeni normal transform emeliyyatlarinda olur buna Gimbal Lock problemi deyilir 
            4 cu bir teref oldugu ucun bu daha stabil isleyir ve yuvarlaqlasdirmada daha yaxsidir 
        */
        #endregion
        #region Euler
        // verdiyimiz dereceye gore obyekti dondurur SADECE 1 DEFE ISLEYIR UPDATE YAZSAQ BELE 
        //transform.rotation = Quaternion.Euler(90, 0, 0);
        #endregion
        #region FromToRotation 
        // Obyekt oz etrafinda donur UPDATE E YAZSAQ HEMISE ISLEYECEK 
        //transform.rotation = Quaternion.FromToRotation(Vector3.right, transform.forward);
        #endregion
        #region Identity
        //Rotation 0 lamaq ucundur 
        //Quaternion.identity
        #endregion
    }

    void Update()
    {
        #region LookRotation
        //LookAt kimi isleyir 
        /* Vector3 ferq = Hedef1.position - transform.position;
        Hedef1.rotation = Quaternion.LookRotation(ferq, Vector3.right); */
        #endregion
        #region Angle
        // duz mentiq angle 
        //float angle = Quaternion.Angle(transform.rotation, Hedef1.rotation);
        //print(angle);
        #endregion
        #region Inverse
        //2 obyekt Tam tersi rotation atir 
        //transform.rotation = Quaternion.Inverse(Hedef1.rotation);
        #endregion


    }
}
