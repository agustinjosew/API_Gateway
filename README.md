# API Gateway
Uno de los desafíos al trabajar con mico-servicios es como lograr una comunicación sin provocar un acoplamiento entre ellos. 

Qué es una API Gateway?
Una API Gateway es una capa extra que añadimos entre ya bien sean nuestro servicios Front End, o clientes externos para que se comuniquen con ella en vez de con el servicio Back end correspondiente. 

Una API Gateway actúa como un reverse proxy al que podemos incluir funcionalidades extra, como pueden ser seguridad, políticas de uso, alertas, etc.

## Cuándo utilizar API Gateway?
Como hemos mencionado algunos de los beneficios de utilizar API Gateway es centralizar el lugar donde se van a hacer dichas llamadas por parte tanto de clientes como de servicios. 

Además nos permite introducir funcionalidades como: 

* Autenticación: el primer filtro de seguridad para el control de acceso.
* Rate Limiting: Significa controlar la cantidad de datos que los clientes pueden utilizar/descargar para así evitar un abuso, o por ejemplo si damos un servicio SaaS nos permite implementar un mayor control con la facturación a dicho cliente. Por ejemplo: las primeras 10 mil llamadas a la api son gratis y luego 2 dolares por cada mil llamadas adicionales, etc.
* Monitorizar las API: todo centralizado hace que sea mas sencillo monitorizar y saber que es lo que más se utiliza y como.
* Si cambiamos un servicio, no necesitamos notificar a los clientes, siempre y cuando no cambiemos el contrato de la API Gateway, ya que el cliente seguirá llamando a la Gateway mientras que la gateway hará la redirección al nuevo servicio.
* Hay muchas más, como caché, load balancers, etc
