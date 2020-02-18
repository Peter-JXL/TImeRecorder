



[![Open Source Love](https://badges.frapsoft.com/os/v1/open-source.svg?v=103)](https://github.com/ellerbrock/open-source-badge/)    ![platform](https://img.shields.io/badge/platform-Windows-blue)



## 本项目已停止更新。正在用Sqlite和Electron重构代码



# 为什么要记录时间

时间是我们宝贵的财富，通过记录时间，可以更客观的了解自己，而不是凭借不可靠的记忆

关于时间统计法，发明并使用的是亚历山大・亚历山德罗维奇・柳比歇夫。

> 柳比歇夫：前苏联昆虫学家、哲学家、数学家。一生发布了 70 余部学术著作，从分散分析、生物分类学到昆虫学，不一而足。一共写了五百多印张，相当于一万二千五百张打字稿。即使以专业作家来看，这也是个庞大的数字。
>
> 而这一切，得益于他在 26 岁时独创的 “时间统计法”—— 通过记录每个事件的花销时间，通过统计和分析，进行月小结和年终总结，以此来改进工作方法、计划未来事务，从而提高对时间的利用效率。期间他不断完善这一统计方法，并一直沿用了 56 年直到逝世。
>
> ​																							                                                              --《奇特的一生》

​	记录时间的好处有很多，最直观的就是可以知道时间花在哪了。人的大脑并不是非常可靠，仅仅凭感觉的话，很容易认为自己过去非常努力；而回顾时间记录，可以发现原来有很多的时间并没有好好利用



# 界面





![](https://s2.ax1x.com/2019/09/02/niEWLQ.png)



![](https://s2.ax1x.com/2019/09/02/niERsg.png)





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





