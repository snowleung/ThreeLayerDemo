## C＃ 三层架构源代码
多层架构是软件开发中的重要主题，其中最基本的是三层架构。三层架构是很早就提出来的一种软件的组织形式。以下以C#语言，表达三层架构在代码中的表现形式。

## 关于三层(Three-tier architecture)

* UI（Presentation layer），表现（层）
  * 是业务功能的出口，应该让用户看到并接受的地方。
  * 界面代码在此层保存。

* BLL（ Business logic layer ），业务逻辑层
  * 是业务功能的*运算*和*处理*中心，是从UI层引申出来的独立层。
  * 业务逻辑代码在此层保存。

* DAL（Data access layer ），数据访问层
  * 数据的 **存储** 和 **查询** *功能*的中心。
  * 存储与查询数据的代码在此层保存。

##### 架构模式应该符合高[内聚](https://zh.wikipedia.org/wiki/%E5%85%A7%E8%81%9A%E6%80%A7_(%E8%A8%88%E7%AE%97%E6%A9%9F%E7%A7%91%E5%AD%B8))低[耦合](https://zh.wikipedia.org/wiki/%E8%80%A6%E5%90%88%E6%80%A7_(%E8%A8%88%E7%AE%97%E6%A9%9F%E7%A7%91%E5%AD%B8))的原则。

## 代码片段

项目代码地址：https://github.com/snowleung/ThreeLayerDemo

UI[代码](https://github.com/snowleung/ThreeLayerDemo/blob/master/UI/Form1.cs)：

* 只有文本框和提示信息
* 引用业务逻辑层进行逻辑运算，如Login, Register等功能

BLL[代码](https://github.com/snowleung/ThreeLayerDemo/blob/master/BLL/UsersManager.cs)：

* 只有业务逻辑的运算
* 引用数据访问层（实现了如何才是登录、如何才是注册等功能）
* 通过模块（User）＋Manager的命名方式来组织代码，方便分块管理。

DAL[代码](https://github.com/snowleung/ThreeLayerDemo/blob/master/DAL/UsersServer.cs)：

* 只有数据的查询和存储运算
* 引入数据库
* 通过模块＋Server的命名方式组织代码，方便管理对应的数据表

##### 还有什么其它没有说到的

* UI层和BLL层，通过函数返回值进行通讯（如成功返回True）
* BLL和DAL层，通过实例化的类进行通讯（如成功返回一个[UserModel](https://github.com/snowleung/ThreeLayerDemo/blob/master/Model/Users.cs)）
* DAL层和数据库，通过DataSet类进行通讯（如有数据则返回一个DataSet）

##REFERENCE
* WIKI: [Three-tier architecture](https://en.wikipedia.org/wiki/Multitier_architecture#Three-tier_architecture)
