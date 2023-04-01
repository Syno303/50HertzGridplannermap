# 50HertzGridplannermap
```
To run the project as docker images install docker and run the following commands:
docker run -p 5000:5000 -td syno303/50hertzgridplannermapapi
docker run -p 80:80 -td syno303/50hertzgridplannermapfrontend
```


`GET /api/GridStation`

```
Returns a list of all available gridstations
```

> Example responses

> 200 Response

json
[
  {
    "id": 0,
    "stationName": "string",
    "coordinate": {
      "longitude": 0,
      "latitude": 0
    },
    "contact": {
      "name": "string",
      "street": "string",
      "number": "string",
      "postalCode": "string",
      "city": "string",
      "country": "string",
      "phone": "string"
    },
    "status": true,
    "kilovoltage": "string"
  }
]
```

<h3 id="get__api_gridstation-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|Inline|

<h3 id="get__api_gridstation-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[GridStationExportDto](#schemagridstationexportdto)]|false|none|none|
|» id|integer(int32)|false|none|none|
|» stationName|string¦null|false|none|none|
|» coordinate|[CoordinateExportDto](#schemacoordinateexportdto)|false|none|none|
|»» longitude|number(double)|false|none|none|
|»» latitude|number(double)|false|none|none|
|» contact|[ContactExportDto](#schemacontactexportdto)|false|none|none|
|»» name|string¦null|false|none|none|
|»» street|string¦null|false|none|none|
|»» number|string¦null|false|none|none|
|»» postalCode|string¦null|false|none|none|
|»» city|string¦null|false|none|none|
|»» country|string¦null|false|none|none|
|»» phone|string¦null|false|none|none|
|» status|boolean|false|none|none|
|» kilovoltage|string¦null|false|none|none|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_GridStation


`POST /api/GridStation`

> Body parameter

```json
{
  "stationName": "string",
  "id": 0,
  "coordinate": {
    "longitude": "string",
    "latitude": "string"
  },
  "contact": {
    "name": "string",
    "street": "string",
    "number": "string",
    "postalCode": "string",
    "city": "string",
    "country": "string",
    "phone": "string"
  },
  "status": true,
  "kilovoltage": 0
}
```

<h3 id="post__api_gridstation-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[GridStationImportDto](#schemagridstationimportdto)|false|none|

> Example responses

> 200 Response

```
{"id":0,"stationName":"string","coordinate":{"longitude":0,"latitude":0},"contact":{"name":"string","street":"string","number":"string","postalCode":"string","city":"string","country":"string","phone":"string"},"status":true,"kilovoltage":"string"}
```

```json
{
  "id": 0,
  "stationName": "string",
  "coordinate": {
    "longitude": 0,
    "latitude": 0
  },
  "contact": {
    "name": "string",
    "street": "string",
    "number": "string",
    "postalCode": "string",
    "city": "string",
    "country": "string",
    "phone": "string"
  },
  "status": true,
  "kilovoltage": "string"
}
```

<h3 id="post__api_gridstation-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|[GridStationExportDto](#schemagridstationexportdto)|

<aside class="success">
This operation does not require authentication
</aside>

## get__api_GridStation_{id}


```

`GET /api/GridStation/{id}`

<h3 id="get__api_gridstation_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```
{"id":0,"stationName":"string","coordinate":{"longitude":0,"latitude":0},"contact":{"name":"string","street":"string","number":"string","postalCode":"string","city":"string","country":"string","phone":"string"},"status":true,"kilovoltage":"string"}
```

```json
{
  "id": 0,
  "stationName": "string",
  "coordinate": {
    "longitude": 0,
    "latitude": 0
  },
  "contact": {
    "name": "string",
    "street": "string",
    "number": "string",
    "postalCode": "string",
    "city": "string",
    "country": "string",
    "phone": "string"
  },
  "status": true,
  "kilovoltage": "string"
}
```

<h3 id="get__api_gridstation_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|[GridStationExportDto](#schemagridstationexportdto)|

<aside class="success">
This operation does not require authentication
</aside>

## put__api_GridStation_{id}

```

`PUT /api/GridStation/{id}`

> Body parameter

```json
{
  "stationName": "string",
  "id": 0,
  "coordinate": {
    "longitude": "string",
    "latitude": "string"
  },
  "contact": {
    "name": "string",
    "street": "string",
    "number": "string",
    "postalCode": "string",
    "city": "string",
    "country": "string",
    "phone": "string"
  },
  "status": true,
  "kilovoltage": 0
}
```

<h3 id="put__api_gridstation_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|
|body|body|[GridStationImportDto](#schemagridstationimportdto)|false|none|

> Example responses

> 200 Response

```
{"id":0,"stationName":"string","coordinate":{"longitude":0,"latitude":0},"contact":{"name":"string","street":"string","number":"string","postalCode":"string","city":"string","country":"string","phone":"string"},"status":true,"kilovoltage":"string"}
```

```json
{
  "id": 0,
  "stationName": "string",
  "coordinate": {
    "longitude": 0,
    "latitude": 0
  },
  "contact": {
    "name": "string",
    "street": "string",
    "number": "string",
    "postalCode": "string",
    "city": "string",
    "country": "string",
    "phone": "string"
  },
  "status": true,
  "kilovoltage": "string"
}
```

<h3 id="put__api_gridstation_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|[GridStationExportDto](#schemagridstationexportdto)|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_GridStation_proximity_{radiusInKm}



```

`POST /api/GridStation/proximity/{radiusInKm}`

> Body parameter

```json
{
  "longitude": 0,
  "latitude": 0
}
```

<h3 id="post__api_gridstation_proximity_{radiusinkm}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|radiusInKm|path|integer(int32)|true|none|
|body|body|[Coordinate](#schemacoordinate)|false|none|

> Example responses

> 200 Response

```
[{"id":0,"stationName":"string","coordinate":{"longitude":0,"latitude":0},"contact":{"name":"string","street":"string","number":"string","postalCode":"string","city":"string","country":"string","phone":"string"},"status":true,"kilovoltage":"string"}]
```

```json
[
  {
    "id": 0,
    "stationName": "string",
    "coordinate": {
      "longitude": 0,
      "latitude": 0
    },
    "contact": {
      "name": "string",
      "street": "string",
      "number": "string",
      "postalCode": "string",
      "city": "string",
      "country": "string",
      "phone": "string"
    },
    "status": true,
    "kilovoltage": "string"
  }
]
```

<h3 id="post__api_gridstation_proximity_{radiusinkm}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|Inline|

<h3 id="post__api_gridstation_proximity_{radiusinkm}-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[GridStationExportDto](#schemagridstationexportdto)]|false|none|none|
|» id|integer(int32)|false|none|none|
|» stationName|string¦null|false|none|none|
|» coordinate|[CoordinateExportDto](#schemacoordinateexportdto)|false|none|none|
|»» longitude|number(double)|false|none|none|
|»» latitude|number(double)|false|none|none|
|» contact|[ContactExportDto](#schemacontactexportdto)|false|none|none|
|»» name|string¦null|false|none|none|
|»» street|string¦null|false|none|none|
|»» number|string¦null|false|none|none|
|»» postalCode|string¦null|false|none|none|
|»» city|string¦null|false|none|none|
|»» country|string¦null|false|none|none|
|»» phone|string¦null|false|none|none|
|» status|boolean|false|none|none|
|» kilovoltage|string¦null|false|none|none|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="50hertz-gridplanner-login">Login</h1>

## post__api_Login



```

`POST /api/Login`

> Body parameter

```json
{
  "username": "string",
  "password": "string"
}
```

<h3 id="post__api_login-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[LoginDto](#schemalogindto)|false|none|

> Example responses

> 200 Response

```
{"userName":"string","claims":["string"]}
```

```json
{
  "userName": "string",
  "claims": [
    "string"
  ]
}
```

<h3 id="post__api_login-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|[UserDto](#schemauserdto)|

<aside class="success">
This operation does not require authentication
</aside>

# Schemas

<h2 id="tocS_ContactExportDto">ContactExportDto</h2>
<!-- backwards compatibility -->
<a id="schemacontactexportdto"></a>
<a id="schema_ContactExportDto"></a>
<a id="tocScontactexportdto"></a>
<a id="tocscontactexportdto"></a>

```json
{
  "name": "string",
  "street": "string",
  "number": "string",
  "postalCode": "string",
  "city": "string",
  "country": "string",
  "phone": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|street|string¦null|false|none|none|
|number|string¦null|false|none|none|
|postalCode|string¦null|false|none|none|
|city|string¦null|false|none|none|
|country|string¦null|false|none|none|
|phone|string¦null|false|none|none|

<h2 id="tocS_ContactImportDto">ContactImportDto</h2>
<!-- backwards compatibility -->
<a id="schemacontactimportdto"></a>
<a id="schema_ContactImportDto"></a>
<a id="tocScontactimportdto"></a>
<a id="tocscontactimportdto"></a>

```json
{
  "name": "string",
  "street": "string",
  "number": "string",
  "postalCode": "string",
  "city": "string",
  "country": "string",
  "phone": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|street|string¦null|false|none|none|
|number|string¦null|false|none|none|
|postalCode|string¦null|false|none|none|
|city|string¦null|false|none|none|
|country|string¦null|false|none|none|
|phone|string¦null|false|none|none|

<h2 id="tocS_Coordinate">Coordinate</h2>
<!-- backwards compatibility -->
<a id="schemacoordinate"></a>
<a id="schema_Coordinate"></a>
<a id="tocScoordinate"></a>
<a id="tocscoordinate"></a>

```json
{
  "longitude": 0,
  "latitude": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|longitude|number(double)|false|none|none|
|latitude|number(double)|false|none|none|

<h2 id="tocS_CoordinateExportDto">CoordinateExportDto</h2>
<!-- backwards compatibility -->
<a id="schemacoordinateexportdto"></a>
<a id="schema_CoordinateExportDto"></a>
<a id="tocScoordinateexportdto"></a>
<a id="tocscoordinateexportdto"></a>

```json
{
  "longitude": 0,
  "latitude": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|longitude|number(double)|false|none|none|
|latitude|number(double)|false|none|none|

<h2 id="tocS_CoordinateImportDto">CoordinateImportDto</h2>
<!-- backwards compatibility -->
<a id="schemacoordinateimportdto"></a>
<a id="schema_CoordinateImportDto"></a>
<a id="tocScoordinateimportdto"></a>
<a id="tocscoordinateimportdto"></a>

```json
{
  "longitude": "string",
  "latitude": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|longitude|string¦null|false|none|none|
|latitude|string¦null|false|none|none|

<h2 id="tocS_GridStationExportDto">GridStationExportDto</h2>
<!-- backwards compatibility -->
<a id="schemagridstationexportdto"></a>
<a id="schema_GridStationExportDto"></a>
<a id="tocSgridstationexportdto"></a>
<a id="tocsgridstationexportdto"></a>

```json
{
  "id": 0,
  "stationName": "string",
  "coordinate": {
    "longitude": 0,
    "latitude": 0
  },
  "contact": {
    "name": "string",
    "street": "string",
    "number": "string",
    "postalCode": "string",
    "city": "string",
    "country": "string",
    "phone": "string"
  },
  "status": true,
  "kilovoltage": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|stationName|string¦null|false|none|none|
|coordinate|[CoordinateExportDto](#schemacoordinateexportdto)|false|none|none|
|contact|[ContactExportDto](#schemacontactexportdto)|false|none|none|
|status|boolean|false|none|none|
|kilovoltage|string¦null|false|none|none|

<h2 id="tocS_GridStationImportDto">GridStationImportDto</h2>
<!-- backwards compatibility -->
<a id="schemagridstationimportdto"></a>
<a id="schema_GridStationImportDto"></a>
<a id="tocSgridstationimportdto"></a>
<a id="tocsgridstationimportdto"></a>

```json
{
  "stationName": "string",
  "id": 0,
  "coordinate": {
    "longitude": "string",
    "latitude": "string"
  },
  "contact": {
    "name": "string",
    "street": "string",
    "number": "string",
    "postalCode": "string",
    "city": "string",
    "country": "string",
    "phone": "string"
  },
  "status": true,
  "kilovoltage": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|stationName|string¦null|false|none|none|
|id|integer(int32)|false|none|none|
|coordinate|[CoordinateImportDto](#schemacoordinateimportdto)|false|none|none|
|contact|[ContactImportDto](#schemacontactimportdto)|false|none|none|
|status|boolean|false|none|none|
|kilovoltage|integer(int32)|false|none|none|

<h2 id="tocS_LoginDto">LoginDto</h2>
<!-- backwards compatibility -->
<a id="schemalogindto"></a>
<a id="schema_LoginDto"></a>
<a id="tocSlogindto"></a>
<a id="tocslogindto"></a>

```json
{
  "username": "string",
  "password": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|username|string¦null|false|none|none|
|password|string¦null|false|none|none|

<h2 id="tocS_UserDto">UserDto</h2>
<!-- backwards compatibility -->
<a id="schemauserdto"></a>
<a id="schema_UserDto"></a>
<a id="tocSuserdto"></a>
<a id="tocsuserdto"></a>

```json
{
  "userName": "string",
  "claims": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|userName|string¦null|false|none|none|
|claims|[string]¦null|false|none|none|

