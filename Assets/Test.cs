using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    
    private int mp = 53; 　　　// マジックポイント

    // 魔法攻撃用の関数
    public void Magic()
    {

        for (int i = 1; i <= 11; i++)
        {
            
            

            if (mp >= 5)
            {
                this.mp = mp - 5;
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
            }
            else if (mp < 5)
            {
                
                Debug.Log("MPが足りないため魔法が使えない。");
            }

        }

    }

}

public class Test : MonoBehaviour
{

    void Start()
    {

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Magic();
        


        int[] array = {10, 20, 30, 40, 50};

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for (int k = 4; k >= 0; k--)
        {
            Debug.Log(array[k]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


