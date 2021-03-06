﻿/************************************************************************************
 * Copyright (c) 2017 All Rights Reserved. 
 * CLR版本：4.0.30319.42000
 * 机器名称：JIAN
 * 命名空间：JCE.DataCenter.Infrastructure.Dependency
 * 文件名：ITransientDependency
 * 版本号：v1.0.0.0
 * 唯一标识：fb42dead-1875-4daa-9537-a5d34074460a
 * 当前的用户域：JIAN
 * 创建人：简玄冰
 * 电子邮箱：jianxuanhuo1@126.com
 * 创建时间：2017/7/11 21:48:26
 * 描述：
 *
 * =====================================================================
 * 修改标记：
 * 修改时间：2017/7/11 21:48:26
 * 修改人：简玄冰
 * 版本号：v1.0.0.0
 * 描述：
 *
/************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCE.DataCenter.Infrastructure.Dependency
{
    /// <summary>
    /// 实现此接口的类型将自动注册为<see cref="LifetimeStyle.Transient"/>模式
    /// </summary>
    public interface ITransientDependency:IDependency
    {
    }
}
