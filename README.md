# 为什么要记录时间

首先推荐一本书：《奇特的一生》 （在books文件夹里有mobi和PDF版本）

​	记录时间的好处有很多，最直观的就是可以知道时间花在哪了。人的大脑并不是非常可靠，仅仅凭感觉的话，很容易认为自己过去非常努力；而回顾时间记录，可以发现原来有很多的时间并没有好好利用





# 软件界面

## 记录窗口

![1563089319713](assets\1563089319713.png)









## 总结窗口

![1563089397483](assets\1563089397483.png)

根据当天时间记录，分类汇总时间，总结可以为今日回顾





## 标签管理窗口

![1563089619036](assets\1563089619036.png)

在Access里的标签表：

![1563089899574](assets\1563089899574.png)

标签体系我设置成了二级标签

因为一级标签我认为有点笼统 ，三级标签或者无限标签的话会让时间记录的成本变高





# 让记录更简单

一件事情越简单，越容易坚持下来。

根据这个原则，设计了如下功能：

- 根据二级标签自动选择一级标签：当在二级标签里输入文本时，当匹配到 Access数据库里一级标签，会自动设置一级标签
- 根据备注自动选择一级和二级标签：当你在记录窗口的备注栏里输入的文本含有 Access数据库里的备注时，会自动设置一级标签和二级标签
- 番茄钟：番茄工作法能有效提高效率，因此简单做了个简单版本的番茄钟应用
- 快捷录入：运行后默认将焦点放在“开始时间”里让用户输入，输入后按Tab键切换到结束时间，然后的Tab顺序为一级标签、二级标签、备注和添加按钮，当焦点在添加按钮时，单击按钮（按下回车更快）后会将数据录入到Access里，同时在窗口中也有体现；
  - 当按下了添加按钮后，默认将结束时间的值覆盖掉开始时间的值，同时将焦点放在结束时间里，让用户添加下一个时间段…直到录入完毕
- 快捷键
  - 切换日期：Ctrl + 左方向键退回到前一天；Ctrl + 右方向键前进一天





