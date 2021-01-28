using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using playerDLL;


public class TextScript : MonoBehaviour
{
    [SerializeField] PlayerController player;
    [SerializeField] InputField Name;
    [SerializeField] InputField Health;
    [SerializeField] Text ShowText;
    [SerializeField] Text HP;

    public void SetPlayerInfo(){
        player.Setting(Name.text,Convert.ToInt32(Health.text));
        ShowText.text = $"My name is {Name.text}";
    } 

    private void Update() {
        HP.text = "HP : " + PlayerInfomation.Health.ToString();
        
    }
    
    
}
