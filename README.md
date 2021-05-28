# yi.bbs--基于.Net5与Vue下的BBS论坛毕业设计系统

本论坛极度**自由化**！用户-角色-权限完全**自定义**！ 论坛各处需求，无需通过修改代码或者数据库，可直接进入系统管理。
快把它成为为你私人定制的论坛吧！

## 适宜人群：

 - 搭建论坛
 - 搭建博客
 - 信息交流平台
 - 参考学习
 - 毕业设计（请注明已使用意框架）

## 更新目录：
v1.1.4------2021/5/28(添加账户ip、简介信息，添加版本管理功能)

v1.1.3------2021/5/26(完善用户额外信息)

v1.1.2------2021/5/26(仓库添加外部程序集)

v1.1.1------2021/5/25(添加邮箱注册功能，修复管理员删帖功能)

v1.1.0------2021/5/24(添加qq登录功能，添加qq绑定账号功能，大幅度完善系统)

v1.0.8------2021/5/23(添加点击头像可互相查看信息功能)

v1.0.7------2021/5/20(添加点赞功能，优化起始界面)

v1.0.6------2021/5/20(添加横幅管理，完善权限系统)

v1.0.5------2021/5/19(优化样式修改功能，添加全局设置功能，优化移动端界面，封装redis交互存储全局设置)

v1.0.4------2021/5/18(完善样式修改功能，修改主题，完善移动端响应式配置，完善表单规则配置)

v1.0.3------2021/5/17(完善权限系统，初步添加搭建主题样式修改框架)

v1.0.2------2021/5/16（添加收藏功能，优化响应式布局界面）

v1.0.1------2021/5/13（完善标签功能）

v1.0.0------2021/5/12 (上传基础框架)

我们将持续更新下去！

## 系统特点：

1：前后端完全分离  2：响应式布局  3：高并发  4：可集群  5：安全  6：高扩展  7：高性能  8：逻辑删除  9：简易


## 功能模块：

用户管理、权限管理、角色管理、主题管理、板块管理、版主管理、标签管理、等级管理、经验管理、信息管理、收藏管理、样式管理、设置管理、横幅管理、点赞管理

持续更新

## 演示效果：

（多说无益，实践才是检验真理的唯一标准）
演示版本: v1.1.1

已上传演示站点：https://jiftcc.com

由于站点正在被使用，已下架管理员账号，请自行注册

（请不要随意修改数据：数据无价）

<hr>

## 安装教程
#### 后端：

 - 安装 Visual Studio 2019
 - 安装.Net5（.Netcore 5.0）

运行：使用 Visual Studio 2019启动sln文件，所有程序已经配置完成，一键启动后端项目
#### 前端：
 - 安装 Node.js
 - 安装npm
 - 修改npm镜像源

运行：npm i安装必要模块之后，npm run serve启动前端项目

#### 数据库：
本项目项目支持各大流行数据库，默认采用**sqlite**+**redis**数据库

 - sqlite：各表关系，数据存放（克隆项目中含有sqlite数据库，无需配置）
 - redis：重要设置、配置存放（克隆项目中不含redis，请关闭或者自行配置reids）


关系型数据库修改操作：（sqlserver，mysql等等）

1：删除现有sqlite包，安装对应的efcore连接数据库包

2：修改appsettings.json连接数据库json配置

3：修改对应的数据库连接字符串与options

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210520202347139.png)

4：使用Nuget控制台命令：Add-Migration xxx迁移，再使用Update-Database更新数据库

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210520202723242.png)

现在，查看你的数据库，已经自动生成！

非关系型数据库修改：（关闭redis）

1：修改settingHelper.cs文件

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210520202920478.png)

2：删除构造方法，并修改代码

```csharp
return CacheWriter.GetCache<int>("commentPage");
```

替换成

```csharp
return [int整形数据];
```

如果想使用redis，请自行添加数据：

 - commentPage：评论页面每页几条数据
 - discussPage：主题页面每页几条数据
 - commentExperience：评论经验
 - discussExperience：发布主题经验
 - title：站点名称

在此，你已能成功启动项目

请准备好，接下来的所有配置，无需再通过代码实现！

<hr>

##  使用教程

### 代码生成器使用

> 一个程序员，项目写的代码越少，代表你越优秀。

你可以拿着本项目代码更改需求，大部分固定代码已通过T4模板自动生成，你只需要给出部分参数，点击转换所有T4模板即可！写代码，如此简单！

![在这里插入图片描述](https://img-blog.csdnimg.cn/2021052021060244.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L1FBUVFWUVFUUQ==,size_16,color_FFFFFF,t_70)

自动生成代码区域：

 - T4DataContext（模型层数据库表）
 - T4IDAL
 - T4IDAL
 - T4IBLL
 - T4BLL
 - T4Startup（启动依赖注入）
 - T4api（前端api模板）
 - T4Component（前端增删改查模板）
 - T4Controller（控制器模板）

T4Model文件夹中含有详细的配置说明

### 用户-角色-权限 简介：

**用户-角色-权限**：

用户拥有不同的角色，角色拥有不同的权限，同时用户还能拥有特殊权限，**你的权限等于，你所有角色拥有的权限+特殊权限**

我们权限认证的方式为JWT，我们并未重新发布令牌，这代表着当你权限发生改变的时候，你必须得**重新登录**以获取最新权限的令牌。（已为后期的集群最好准备）

### 用户管理：
![在这里插入图片描述](https://img-blog.csdnimg.cn/20210520203837279.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L1FBUVFWUVFUUQ==,size_16,color_FFFFFF,t_70)

你可在这里添加、修改、批量删除、查询用户信息

在操作栏中，你可以为该用户**设置角色**以及**特殊权限**

### 角色管理：

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210520204037845.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L1FBUVFWUVFUUQ==,size_16,color_FFFFFF,t_70)

你可以在这里添加、修改、批量删除、查询角色信息

在操作栏中，你可以为该角色**设置权限**

另外，有些角色是特殊的，它将会在项目第一次启动时自动创建

”l-x“：自动对应等级用户添加该权限，例如：

张三目前是3级，他将拥有l-1,l-2,l-3的角色

至于每级可做的权限，由你来自定义设置

### 权限管理：
![在这里插入图片描述](https://img-blog.csdnimg.cn/20210520204339535.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L1FBUVFWUVFUUQ==,size_16,color_FFFFFF,t_70)

你可以在这里添加、修改、批量删除、查询权限信息

权限路由是你控制**用户导航栏**的信息：

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210520204536624.png)

请注意，这里由一些特殊的权限将会在系统第一次启动时，**自动生成**

请记住它们：

 - 用户管理
 - 角色管理
 - 权限管理
 - 板块管理
 - 等级管理
 - 我的信息
 - a-admin
 - 我的主题
 - 标签管理
 - 收藏管理
 - 发布主题
 - 发布评论
 - 修改信息
 - 样式管理
 - 设置管理
 - 横幅管理
 - 点赞管理

每一个权限代表一个功能，**你可以自由地将这些权限给不同的角色，或者通过用户管理的特殊权限来设置**

其中注意a-admin特殊的格式**a-xxx代表拥有操作xxx板块的权限**

**a-admin为操作所有板块的权限**

现在来看看你的前端导航栏，由3个分支：**根目录**、**我的权限**、**其他**

这里是由权限的路由控制，权限的路由分3个种类：

 - 权限路由为空（只有权限，不会在导航页面显示）
 - 权限路由为一个链接（会在导航页面显示，由前端文件进行分类）
 - 权限路由为/my/+一个链接（会在其他中显示）

前端导航栏分布文件：

/utils/myaction.js

```javascript
const actionList = [
    "用户管理",
    "角色管理",
    "权限管理",
    "板块管理",
    "等级管理",
    "主题管理",
    "设置管理",
    "横幅管理"
];
export default { actionList };
```

你可以在这里进行修改哪些权限将显示在“**我的权限**”中

### 其他管理：

我们将在后面的版本中逐步添加

<hr>
# 推广

#### 本系统应用Yi意框架（也是本人搭建的一套快速开发框架）
基于.NET5的前后端分离三层架构的高并发高解耦简易型框架--Yi意框架（意义是为了开发更简易）

#### 软件架构
Yi意框架

	Yi意框架源码

		CC.Yi（.Net5核心版本）

	Yi意框架应用（图片管理系统）

		CC.Yi.PictureManagement（Betav0.0.1Yi框架后端）

		CC.Yi.PictureManagement（Vue-ElementUI前端）

	Yi意框架应用（作业管理系统）

		CC.Yi.WorkManagement（v1.0.0Yi意框架后端）

		CC.Yi.WorkManagement（Vue-ElementUI前端）

	Yi意框架应用（权限管理系统）

		CC.Yi.RolePermission（v1.1.0Yi意框架后端）

		CC.Yi.RolePermission（Vue-Vuetify前端）

	Yi意框架应用（题库管理系统）

		CC.Yi.QuestionBank（v1.2.0Yi意框架后端）

		CC.Yi.QuestionBank（Vue-Vuetify前端）

	Yi意框架最终应用（论坛系统）

		CC.Yi.bbs（v2.0.0Yi意框架后端）

		CC.Yi.bbs（Vue-Vuetify前端）

架构：后端.NET5 ，前端Vue

支持的数据库： SQL Server，MySQL，SQLite，reidis

操作系统：Windows，Linux

扩展：EFcore，Autofac，Identity，Castle，Redis，Swagger，T4 ，Nlog ，Jwt

封装：Json处理模块，滑动验证码模块，base64图片处理模块，HTTP请求,过滤器

思想：简单工厂模式，抽象工厂模式，观察者模式，面向AOP思想，面向对象开发

其他: nginx前后端集群配置，前后端跨域设置，权限认证配置，swaggerToken配置


#### 目录结构
Model：模型层（first code代码优先添加模型，数据自动生成）

DAL：数据处理层（处理数据但并未加载进内存）

BLL：业务逻辑层（数据的逻辑将在这层处理）

Common：工具层（工具人层，方法已封装，一键调用）

API：接口层（接入Swagger，可视化测试接口）

#### 安装教程
我们将在之后更新教程手册！

1.  下载全部源码
2.  使用Visual Studio 2019在windows环境中打开CC.Yi.sln文件即可


#### 使用说明
我们将在之后更新教程手册！

1.  添加一个数据库，并修改连接数据库的配置文件
2.  添加模型类，使用Add-Migration xxx迁移，再使用Update-Database更新数据库
3.  向T4Model添加模型名，一键转换生成T4
4.  控制器构造函数进行依赖注入直接使用

#### 联系我们：
QQ：454313500


