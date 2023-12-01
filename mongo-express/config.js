var options = {
    mongodb: {
      server: {
        ssl: false,
        sslValidate: false
      },
      auth: {
        user: 'root',
        password: 'root'
      }
    },
    site: {
      host: '0.0.0.0',
      port: 8081,
      cookieSecret: 'Teste_conteiner_S107'
    },
    useBasicAuth: true,
    basicAuth: {
      username: 'Teste_Edu',
      password: 'TesteInatel'
    }
  };
  module.exports = options;
  