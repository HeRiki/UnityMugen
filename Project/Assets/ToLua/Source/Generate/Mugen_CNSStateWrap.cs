﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Mugen_CNSStateWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Mugen.CNSState), typeof(System.Object));
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("projid", get_projid, set_projid);
		L.RegVar("projanim", get_projanim, set_projanim);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_projid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSState obj = (Mugen.CNSState)o;
			int ret = obj.projid;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index projid on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_projanim(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSState obj = (Mugen.CNSState)o;
			int ret = obj.projanim;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index projanim on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_projid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSState obj = (Mugen.CNSState)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.projid = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index projid on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_projanim(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSState obj = (Mugen.CNSState)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.projanim = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index projanim on a nil value");
		}
	}
}

