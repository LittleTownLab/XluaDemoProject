using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace XluaPro
{
	public class XluaHelloWorld : MonoBehaviour 
	{
        LuaEnv env = null;
        string strLua1 = "print('this is lua run')";
        string strLua2 = "CS.UnityEngine.Debug.Log('this is c# run')";
        private void Start()
        {
            env = new LuaEnv();

            env.DoString(strLua1);
            env.DoString(strLua2);

        }

        private void OnDestroy()
        {
            env.Dispose();
        }
    }
}