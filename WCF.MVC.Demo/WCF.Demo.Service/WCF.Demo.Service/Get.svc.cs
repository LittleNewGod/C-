﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF.Demo.Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Get”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Get.svc 或 Get.svc.cs，然后开始调试。
    public class Get : IGet
    {
        List<Model.User> IGet.DoWork()
        {
            return DAL.User.GetUsers();
        }
    }
}
