using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginGame : MonoBehaviour
{
    public GameObject loginPanel;
    public GameObject registerPanel;
    public GameObject settingPanel;
    public InputField r_userName;
    public InputField r_passWord;
    public InputField cr_passWord;
    public InputField userName;
    public InputField passWord;
    string name = "";//临时存储账号
    string pass = "";//临时存储学号
    string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz12345678900123456789";
    string showText = "";//展示的验证码的字符串
    public Text textShow;//文本展示在UI界面上
    public InputField setText;
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        r_userName = r_userName.GetComponent<InputField>();
        r_passWord = r_passWord.GetComponent<InputField>();
        cr_passWord = cr_passWord.GetComponent<InputField>();
        userName = userName.GetComponent<InputField>();
        passWord = passWord.GetComponent<InputField>();
        textShow = textShow.GetComponent<Text>();
        setText = setText.GetComponent<InputField>();
    }
    public void SelectString()
    {
        showText = "";
        for (int i = 0; i < 4; i++)
        {
            index = Random.Range(0, str.Length);//最大值取不到
            showText += str[index];
        }
        textShow.text = showText;
        setText.text = "";
        showText = showText.ToLower();
    }

    public void ConfirmRegister()
    {
        if (string.IsNullOrEmpty(r_userName.text) || string.IsNullOrEmpty(r_passWord.text) || r_passWord.text != cr_passWord.text)
        {
            print("注册失败,重新注册");//注册失败清空已填注册信息
            r_userName.text = "";
            r_passWord.text = "";
            cr_passWord.text = "";
            return;
        }
        name = r_userName.text;
        pass = r_passWord.text;
        r_userName.text = "";
        r_passWord.text = "";
        cr_passWord.text = "";
        print("注册成功" + name + " " + pass);
        SelectString();
        registerPanel.SetActive(false);
    }

    public void Login()
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass))
        {
            userName.text = "";
            passWord.text = "";
            SelectString();
            print("账号还没注册，请先注册");
            return;
        }
        if (name == userName.text && pass == passWord.text)
        {
            if (setText.text.ToLower() == showText)
            {
                print("登录成功");
                UnityEngine.SceneManagement.SceneManager.LoadScene(1);

            }
            else
            {
                print("验证码失败");
                SelectString();
            }
        }
        else
        {
            SelectString();
            print("登录失败");
        }
        userName.text = "";
        passWord.text = "";
    }

    public void OpenLoginPanel()
    {
        SelectString();
        loginPanel.SetActive(true);
    }
    public void OpenRegisterPanel()
    {
        registerPanel.SetActive(true);
    }
    public void CloseRegisterPanel()
    {
        r_userName.text = "";
        r_passWord.text = "";
        cr_passWord.text = "";
        registerPanel.SetActive(false);
    }
    public void OpenSettingPanel()
    {
        settingPanel.SetActive(true);
    }
    public void CloseSettingPanel()
    {
        settingPanel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
