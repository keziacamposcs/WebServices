# WebServices

![alt text](https://github.com/keziacamposcs/WebServices/blob/main/README/1.png)

![alt text](https://github.com/keziacamposcs/WebServices/blob/main/README/2.png)

### Consumindo WebService - Correios (🇧🇷)

1) Os Correios fornece um WebService para consulta dos seus serviços:

```url
https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl
```

Serviços SOAP normalmente seguem uma especificação chamado **WSDL**

<details><summary>O que é WSDL?</summary>

WSDL (Web Services Description Language) é uma linguagem baseada em XML usada para descrever serviços web e definir a interface de um serviço. O objetivo do WSDL é fornecer uma descrição formal e precisa de como um serviço web pode ser acessado e utilizado por um cliente.

O WSDL define as operações que um serviço oferece, os parâmetros de entrada e saída para cada operação e a forma como esses parâmetros são codificados. Ele também define a localização do serviço (URL) e o protocolo de comunicação utilizado (como SOAP ou REST).

O documento WSDL é uma descrição em formato XML que pode ser consumida por ferramentas de desenvolvimento para gerar código cliente e servidor automaticamente, facilitando a integração entre sistemas distribuídos.

Um exemplo de uso do WSDL é em serviços SOAP. Quando um cliente precisa se comunicar com um serviço SOAP, ele pode consultar o documento WSDL para obter informações sobre as operações disponíveis, como chamar essas operações e quais parâmetros são necessários para cada uma. Com base nessas informações, o cliente pode gerar o código necessário para chamar o serviço e enviar as solicitações.

O WSDL é uma parte importante do desenvolvimento de serviços web, pois permite a comunicação e integração entre sistemas distribuídos, independentemente das plataformas e tecnologias utilizadas.
</details>

A página vai ter conteúdos como esse:
![image](https://github.com/keziacamposcs/WebServices/assets/32270979/a7125e95-a465-4cce-a036-3f183eec8243)


2) Utiliza-se a extensão **Wizdler**:

<details><summary>O que Wizdler faz?</summary>
Wizdler é uma extensão do Google Chrome que permite testar serviços web baseados em protocolo SOAP diretamente do navegador. Com o Wizdler, é possível enviar mensagens SOAP para um serviço web e visualizar a resposta do servidor, sem a necessidade de instalar uma ferramenta dedicada de testes de SOAP.

O Wizdler é fácil de usar: basta instalar a extensão no navegador e inserir a URL do serviço web que se deseja testar. A partir daí, é possível explorar as operações disponíveis, visualizar as mensagens SOAP que serão enviadas e as respostas recebidas do servidor.

Além disso, o Wizdler também permite personalizar as configurações de envio das mensagens SOAP, como adicionar cabeçalhos personalizados ou alterar o tipo de codificação utilizado.

O Wizdler é uma ferramenta útil para desenvolvedores que precisam testar serviços web baseados em protocolo SOAP, pois permite uma forma fácil e rápida de verificar a comunicação entre o cliente e o servidor. Ele também é útil para entender como os serviços web SOAP funcionam e para depurar problemas de integração entre sistemas distribuídos.
</details>


![image](https://github.com/keziacamposcs/WebServices/assets/32270979/969b84d0-31a4-4cd1-8584-0ee01102bbea)


3) Seleciona o que você precisa e faz a copia do texto para então usa-lo no Postman:

![image](https://github.com/keziacamposcs/WebServices/assets/32270979/9ffae27e-f00c-46b8-8e1c-e3b152a00423)

4) No Postman testa com a variável que precisa:

![image](https://github.com/keziacamposcs/WebServices/assets/32270979/3d5d6d80-8ea9-407d-aca5-316bc1c0c6f1)
