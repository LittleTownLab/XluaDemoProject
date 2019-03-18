using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace XluaPro
{
	public class RunLuaByFile : MonoBehaviour 
	{
        LuaEnv env = null;

        private void Start()
        {
            env = new LuaEnv();

            TextAsset txtAsset = Resources.Load<TextAsset>("SimpleLua.lua");
            env.DoString(txtAsset.ToString());
        }

        private void OnDestroy()
        {
            env.Dispose();
        }
    }
}