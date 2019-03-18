using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace XluaPro
{
	public class RunLuaByRequire : MonoBehaviour 
	{
        LuaEnv env = null;

        private void Start()
        {
            env = new LuaEnv();

            env.DoString("require 'SimpleLua'");

        }

        private void OnDestroy()
        {
            env.Dispose();
        }
    }
}