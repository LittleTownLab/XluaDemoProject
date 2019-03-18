using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace XluaPro
{   
	public class CallLuaByGlableVer : MonoBehaviour 
	{
        LuaEnv env = null;
        private void Start()
        {
            env = new LuaEnv();
            env.DoString("require 'CsharpCallLua'");

            string str1 = env.Global.Get<string>("str");
            int number = env.Global.Get<int>("str");
           // int num = env.Global.Get<int>("num");
            float floNumber = env.Global.Get<float>("floNumber");
            bool IsFirstTime = env.Global.Get<bool>("IsFirstTime");

            Debug.Log("str1 " + str1);
            Debug.Log("number " + number);
            //Debug.Log("num " + num);
            Debug.Log("floNumber " + floNumber);
            Debug.Log("IsFirstTime " + IsFirstTime);
        }
    }
}