sidebar_position: 1
slug: /api
API 参考
RAGFlow 提供了 RESTful APIs，以便您将其功能集成到第三方应用程序中。
基本 URL
https://demo.ragflow.io/v1/

授权
RAGFlow 的所有 RESTful APIs 使用 API 密钥进行授权，因此请妥善保管并不要暴露给前端。在请求头中放入您的 API 密钥。
Authorization: Bearer {API_KEY}

:::note 在当前设计中，从 RAGFlow 获取的 RESTful API 密钥不会过期。 :::
获取您的 API 密钥：
- 在 RAGFlow 中，点击页面顶部中间的聊天标签。
- 悬停在相应的对话上 > 聊天机器人 API 以显示聊天机器人 API 配置页面。
- 点击 API 密钥 > 创建新密钥来创建您的 API 密钥。
- 复制并安全保存您的 API 密钥。

创建对话
此方法为特定用户创建一个新的对话。
请求
请求 URI
:::note 您需要保存响应数据中返回的 data.id 值，这是后续对话的会话 ID。 :::
请求参数

请求参数
||||||
|-|-|-|-|-|
|名称|类型|是否必须|描述|id|
|||字符串|是|分配给对话会话的唯一标识符。id 必须少于32个字符且不能为空。支持以下字符集：
- 26个小写英文字母 (a-z)
- 26个大写英文字母 (A-Z)
- 10个数字 (0-9)
- "_", "-", "."|

消息
message: 指定对话会话中的所有对话。role: "user" 或 "assistant".content: 用户或助手的文本内容。引用格式如 ##0$$。中间的数字（本例中为0）表示它引用的是data.reference.chunks中的哪一部分。user_id: 由调用者设置。reference: 每个引用对应于data.message中助手的一个答案。

获取文档列表
此方法从指定的知识库检索文档列表。
请求
请求 URI
||||
|-|-|-|
|方法|请求 URI|POST|
|||/api/list_kb_docs|
请求参数
||||||
|-|-|-|-|-|
|名称|类型|是否必须|描述|kb_name|
|||字符串|是|知识库的名称，从中获取文档列表。|
||page|整数|否|页数，默认:1。|
||page_size|整数|否|每页的文档数量，默认:15。|
||orderby|字符串|否|chunk_num, create_time, 或 size，默认:create_time|
||desc|布尔|否|默认:True。|
||keywords|字符串|否|文档名称的关键字。|

删除文档
此方法通过文档ID或名称删除文档。
请求
请求 URI
||||
|-|-|-|
|方法|请求 URI|DELETE|
|||/api/document|
请求参数
||||||
|-|-|-|-|-|
|名称|类型|是否必须|描述|doc_names|
|||列表|否|文档名称列表。如果未设置doc_ids，则不能为空。|
||doc_ids|列表|否|文档ID列表。如果未设置doc_names，则不能为空。|

获取文档内容
此方法检索文档的内容。
请求
请求 URI
||||
|-|-|-|
|方法|请求 URI|GET|
|||/document/get/<id>|

上传文件
此方法将特定文件上传到指定的知识库。
请求
请求 URI
||||
|-|-|-|
|方法|请求 URI|POST|
|||/api/document/upload|
请求参数
||||||
|-|-|-|-|-|
|名称|类型|是否必须|描述|file|
|||文件|是|要上传的文件。|
||kb_name|字符串|是|要上传文件的知识库名称。|
||parser_id|字符串|否|使用的解析方法（分块模板）。
- "naive": 通用；
- "qa": 问答；
- "manual": 手动；
- "table": 表格；
- "paper": 论文；
- "laws": 法律法规；
- "presentation": 演示文稿；
- "picture": 图片；
- "one": 一个。|
||run|字符串|否|1: 自动开始文件解析。如果未设置parser_id，RAGFlow默认使用通用模板。|

获取文档片段
此方法通过doc_name或doc_id检索特定文档的片段。
请求
请求 URI
||||
|-|-|-|
|方法|请求 URI|GET|
|||/api/list_chunks|
请求参数
||||||
|-|-|-|-|-|
|名称|类型|是否必须|描述|doc_name|
|||字符串|否|知识库中文档的名称。如果未设置doc_id，则不能为空。|
||doc_id|字符串|否|知识库中文档的ID。如果未设置doc_name，则不能为空。|
