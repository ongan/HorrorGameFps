using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    public static float distanceFromTarget;
    //bir çok interaktif nesnenin uzaklığını ölçmek için değişkeni static yaptık
    //ve diğer scriptlerden ulaşabilmek için yaptık
    //yani hedeften uzaklık olarak hesaplamak için
    public float toTarget;
    // toTarget gördüğümüz her nesneye olan uzaklık olacak duvar yer zemin tavan vs gibi hesaplaması için
    
    void Update()
    {
        RaycastHit hit; //bir ışın demeti oluşturduk ve buna hit adını verdik

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        //Physics.Raycast bir nesneye çarpıp çarpmadığımızı kontrol içinm yazdık
        //burada fizik objesinden bir ışın yolluyoruz
        //ve transform.position (burada bizim poziyonumuzdan) yani orijin olan merkezden
        //transform.TransformDirection(Vector3.forward), yani önümüze doğru bir ışın çıkar
        //out hit ise burada bize verdiği çıktı
        {
            toTarget = hit.distance;
            //toTarget dediğimizi ışının uzunluğuna atıyoruz
            //yani burada toTarget mesela duvarsa hit.distance da duavara olan uzaklıktır ve bunu hesaplar
            distanceFromTarget = toTarget;
            //burada da ışının toTarget a olan uzaklığı 
        }
    }
}
