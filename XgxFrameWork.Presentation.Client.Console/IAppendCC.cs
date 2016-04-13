using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;
using Dos.Model;
namespace Dos.Model
{
	public partial interface IAppendCC:IDal<AppendCC>
	{
		AppendCC GetNewAppendCC();
	}
	public partial interface IEntityFactory
	{
		IAppendCC CreatNewIAppendCC();
	}
}

