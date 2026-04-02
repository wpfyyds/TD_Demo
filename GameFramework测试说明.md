# Game Framework框架测试说明

## 框架安装情况

已成功安装Game Framework框架到Unity项目中，包含以下内容：

- **框架核心**: GameFramework.dll
- **Unity集成**: UnityGameFramework脚本和组件
- **资源文件**: GameFramework.prefab
- **测试脚本**: GameFrameworkTest.cs
- **测试场景**: GameFrameworkTestScene.unity

## 运行测试步骤

1. **打开Unity项目**
   - 打开 `TD_Demo` 文件夹作为Unity项目

2. **加载测试场景**
   - 在Project窗口中找到 `Assets/Scenes/GameFrameworkTestScene.unity`
   - 双击加载场景

3. **运行测试**
   - 点击Unity编辑器顶部的"Play"按钮
   - 在Console窗口中查看输出

## 预期结果

运行游戏后，Console窗口应该输出：
```
框架安装成功
```

## 框架功能

Game Framework框架包含以下核心模块：
- 配置管理 (Config)
- 数据结点 (DataNode)
- 数据表 (DataTable)
- 调试器 (Debugger)
- 下载管理 (Download)
- 实体管理 (Entity)
- 事件系统 (Event)
- 文件系统 (FileSystem)
- 有限状态机 (FSM)
- 本地化 (Localization)
- 网络通信 (Network)
- 对象池 (ObjectPool)
- 流程管理 (Procedure)
- 资源管理 (Resource)
- 场景管理 (Scene)
- 设置管理 (Setting)
- 声音管理 (Sound)
- UI管理 (UI)

## 后续开发

可以基于此框架开发塔防肉鸽游戏，按照技术文档中的架构设计进行扩展和开发。