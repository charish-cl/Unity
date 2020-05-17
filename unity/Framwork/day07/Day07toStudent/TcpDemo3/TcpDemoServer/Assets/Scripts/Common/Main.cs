using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Main : MonoBehaviour 
{ 
    public void Loading(string loadName)
    {
        //获得输入
        string txtIp = this.transform.Find("InputFieldIP").GetComponent<InputField>().text;
        string txtProt = this.transform.Find("InputFieldProt").GetComponent<InputField>().text;
        if ((!string.IsNullOrEmpty(txtIp) ) && (!string.IsNullOrEmpty(txtIp)))
        {
            if (loadName == "Server")
            {
                ServerTest.ip = txtIp;
                ServerTest.port = int.Parse(txtProt);
            }
            else
            {
                TcpClientService.Ip = txtIp;
                TcpClientService.Prot = int.Parse(txtProt);
            }
        }
        //加载场景
        SceneManager.LoadScene(loadName);
    }
}
