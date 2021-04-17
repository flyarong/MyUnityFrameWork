﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class InputUILongPressEventWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(InputUILongPressEvent), typeof(InputUIEventBase));
		L.RegFunction("GetEventKey", GetEventKey);
		L.RegFunction("New", _CreateInputUILongPressEvent);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateInputUILongPressEvent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				InputUILongPressEvent obj = new InputUILongPressEvent();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: InputUILongPressEvent.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEventKey(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			string o = InputUILongPressEvent.GetEventKey(arg0, arg1, arg2);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

