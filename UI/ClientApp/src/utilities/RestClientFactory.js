import axios from 'axios';

class RestClientFactory {
    headers = {
        'X-Caller-Scopes': 'sistema-logistica',
        'X-Scope-Id': 'sistema-logistica',
        'Accept': 'application/json',
        'Content-Type': 'application/json',
      };
  timeout = 3000;
  baseUrl = '';

  constructor(url = '') {
    this.baseUrl = url;
  }

  setHeaders(headers) {
    this.headers = headers;
    return this;
  }

  setTimeout(timeout) {
    this.timeout = timeout;
    return this;
  }

  setBaseUrl(baseUrl) {
    this.baseUrl = baseUrl;
    return this;
  }

  extendHeaders(headers) {
    this.headers = { ...this.headers, ...headers };
    return this;
  }

  create() {
    return axios.create({
      baseURL: this.baseUrl,
      timeout: this.timeout,
      headers: this.headers,
    });
  }
}

export default RestClientFactory;