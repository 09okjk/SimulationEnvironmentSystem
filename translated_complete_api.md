
---
sidebar_position: 1
slug: /api
---

# API参考

RAGFlow 提供RESTful API，您可以将其功能集成到第三方应用程序中。

## 基本URL
```
https://{访问地址}/v1/
```

## 授权

RAGFlow的所有RESTful API都使用API密钥进行授权，请妥善保管，不要暴露在前端。
将您的API密钥放在请求头中。

```buildoutcfg
Authorization: Bearer {API_KEY}
```

:::note
在当前设计中，您从RAGFlow获得的RESTful API密钥与您的帐户相关联。确保不要共享此密钥，并将其保密。
:::

## API请求格式

所有API请求都应使用HTTPS协议发送，方法为`POST`、`GET`、`PUT`和`DELETE`。请参阅具体的API文档以获取详细信息。

### 请求头

API请求必须包含以下请求头：

```buildoutcfg
Content-Type: application/json
Authorization: Bearer {API_KEY}
```

### 请求体

所有带有请求体的API调用都必须使用JSON格式。请根据API接口的要求，在请求体中包含所需的字段和参数。

### 响应格式

API响应为JSON格式，包含请求的结果或错误信息。以下是一个典型的成功响应示例：

```json
{
  "success": true,
  "data": { ... }
}
```

如果请求失败，响应将包含错误信息：

```json
{
  "success": false,
  "error": "Invalid request"
}
```

## 错误处理

RAGFlow的API会返回相应的HTTP状态码来指示请求是否成功。常见状态码包括：

- `200 OK`: 请求成功。
- `400 Bad Request`: 请求格式错误或缺少必要参数。
- `401 Unauthorized`: API密钥无效或缺失。
- `403 Forbidden`: 无权限访问资源。
- `500 Internal Server Error`: 服务器内部错误，请稍后重试。

## API接口

### 1. 获取数据

使用此API接口可以获取特定资源的数据。

- **URL**: `/data`
- **方法**: `GET`
- **请求参数**: 
    - `id`: 要获取的数据的ID（必需）。

#### 示例请求

```bash
curl -X GET https://demo.ragflow.io/v1/data?id=123 -H "Authorization: Bearer {API_KEY}"
```

#### 示例响应

```json
{
  "success": true,
  "data": {
    "id": 123,
    "name": "Example Data",
    "description": "This is a sample response."
  }
}
```

### 2. 创建新资源

使用此API接口可以创建新资源。

- **URL**: `/data`
- **方法**: `POST`
- **请求体**:
    - `name`: 新资源的名称（必需）。
    - `description`: 新资源的描述（可选）。

#### 示例请求

```bash
curl -X POST https://demo.ragflow.io/v1/data -H "Authorization: Bearer {API_KEY}" -H "Content-Type: application/json" -d '{"name": "New Data", "description": "This is a new data resource."}'
```

#### 示例响应

```json
{
  "success": true,
  "data": {
    "id": 124,
    "name": "New Data",
    "description": "This is a new data resource."
  }
}
```

### 3. 更新资源

使用此API接口可以更新已有资源的信息。

- **URL**: `/data/{id}`
- **方法**: `PUT`
- **请求体**:
    - `name`: 新的资源名称（可选）。
    - `description`: 新的资源描述（可选）。

#### 示例请求

```bash
curl -X PUT https://demo.ragflow.io/v1/data/124 -H "Authorization: Bearer {API_KEY}" -H "Content-Type: application/json" -d '{"name": "Updated Data", "description": "This data has been updated."}'
```

#### 示例响应

```json
{
  "success": true,
  "data": {
    "id": 124,
    "name": "Updated Data",
    "description": "This data has been updated."
  }
}
```

### 4. 删除资源

使用此API接口可以删除指定的资源。

- **URL**: `/data/{id}`
- **方法**: `DELETE`
- **请求参数**: 
    - `id`: 要删除的资源的ID（必需）。

#### 示例请求

```bash
curl -X DELETE https://demo.ragflow.io/v1/data/124 -H "Authorization: Bearer {API_KEY}"
```

#### 示例响应

```json
{
  "success": true,
  "message": "Resource deleted successfully."
}
```

