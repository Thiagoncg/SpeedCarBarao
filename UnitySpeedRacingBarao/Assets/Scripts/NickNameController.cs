using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NickNameController : MonoBehaviour
{
    [SerializeField] private Text textNameCar;
    [SerializeField] private InputField InputNickName;
    [SerializeField] private GameObject canvasNickName;

    public void SaveNickName()
    {
        textNameCar.text = InputNickName.text;
        canvasNickName.SetActive(false);
    }

}
