# 50HertzGridplannermap

# To run the project as docker images install docker and run the following commands:
# docker run -p 5000:5000 -td syno303/50hertzgridplannermapapi
# docker run -p 80:80 -td syno303/50hertzgridplannermapfrontend

---
title: 50Hertz Gridplanner v1
language_tabs:
  - shell: Shell
  - http: HTTP
  - javascript: JavaScript
  - ruby: Ruby
  - python: Python
  - php: PHP
  - java: Java
  - go: Go
toc_footers: []
includes: []
search: true
highlight_theme: darkula
headingLevel: 2

---

<!-- Generator: Widdershins v4.0.1 -->

<h1 id="50hertz-gridplanner">50Hertz Gridplanner v1</h1>

> Scroll down for code samples, example requests and responses. Select a language for code samples from the tabs above or the mobile navigation menu.

<h1 id="50hertz-gridplanner-gridstation">GridStation</h1>

## get__api_GridStation

> Code samples

```shell
# You can also use wget
curl -X GET /api/GridStation \
  -H 'Accept: text/plain'

```

```http
GET /api/GridStation HTTP/1.1

Accept: text/plain

```

```javascript

const headers = {
  'Accept':'text/plain'
};

fetch('/api/GridStation',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain'
}

result = RestClient.get '/api/GridStation',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain'
}

r = requests.get('/api/GridStation', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/api/GridStation', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/api/GridStation");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/api/GridStation", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /api/GridStation`

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

> Code samples

```shell
# You can also use wget
curl -X POST /api/GridStation \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain'

```

```http
POST /api/GridStation HTTP/1.1

Content-Type: application/json
Accept: text/plain

```

```javascript
const inputBody = '{
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
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain'
};

fetch('/api/GridStation',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain'
}

result = RestClient.post '/api/GridStation',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain'
}

r = requests.post('/api/GridStation', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/api/GridStation', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/api/GridStation");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/api/GridStation", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

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

> Code samples

```shell
# You can also use wget
curl -X GET /api/GridStation/{id} \
  -H 'Accept: text/plain'

```

```http
GET /api/GridStation/{id} HTTP/1.1

Accept: text/plain

```

```javascript

const headers = {
  'Accept':'text/plain'
};

fetch('/api/GridStation/{id}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain'
}

result = RestClient.get '/api/GridStation/{id}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain'
}

r = requests.get('/api/GridStation/{id}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/api/GridStation/{id}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/api/GridStation/{id}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/api/GridStation/{id}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

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

> Code samples

```shell
# You can also use wget
curl -X PUT /api/GridStation/{id} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain'

```

```http
PUT /api/GridStation/{id} HTTP/1.1

Content-Type: application/json
Accept: text/plain

```

```javascript
const inputBody = '{
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
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain'
};

fetch('/api/GridStation/{id}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain'
}

result = RestClient.put '/api/GridStation/{id}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain'
}

r = requests.put('/api/GridStation/{id}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/api/GridStation/{id}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/api/GridStation/{id}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/api/GridStation/{id}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

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

> Code samples

```shell
# You can also use wget
curl -X POST /api/GridStation/proximity/{radiusInKm} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain'

```

```http
POST /api/GridStation/proximity/{radiusInKm} HTTP/1.1

Content-Type: application/json
Accept: text/plain

```

```javascript
const inputBody = '{
  "longitude": 0,
  "latitude": 0
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain'
};

fetch('/api/GridStation/proximity/{radiusInKm}',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain'
}

result = RestClient.post '/api/GridStation/proximity/{radiusInKm}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain'
}

r = requests.post('/api/GridStation/proximity/{radiusInKm}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/api/GridStation/proximity/{radiusInKm}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/api/GridStation/proximity/{radiusInKm}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/api/GridStation/proximity/{radiusInKm}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

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

> Code samples

```shell
# You can also use wget
curl -X POST /api/Login \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain'

```

```http
POST /api/Login HTTP/1.1

Content-Type: application/json
Accept: text/plain

```

```javascript
const inputBody = '{
  "username": "string",
  "password": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain'
};

fetch('/api/Login',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain'
}

result = RestClient.post '/api/Login',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain'
}

r = requests.post('/api/Login', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/api/Login', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/api/Login");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/api/Login", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

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

