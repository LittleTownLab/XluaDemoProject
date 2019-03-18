using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System.IO;

namespace XluaPro
{
	public class RunLuaBySelfDefLoader : MonoBehaviour 
	{
        LuaEnv env = new LuaEnv();

        private void Start()
        {
            env.AddLoader(CustomMyLoader);
            env.DoString("require 'CustomDIRLuaFile'");
        }

        byte[] CustomMyLoader(ref string fileName)
        {
            string luaPath = Application.dataPath +"/Scripts/LuaScripts/" + fileName + ".lua";
            string strLuaContent = File.ReadAllText(luaPath);
            byte[] byArrayReturn = System.Text.Encoding.UTF8.GetBytes(strLuaContent);

            return byArrayReturn;
        }
    }
}