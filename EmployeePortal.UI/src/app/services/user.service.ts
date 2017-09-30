import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';

import { AppConfig } from '../config/index';
import { User } from '../models/index';
import { TokenStore } from './token.service';

@Injectable()
export class UserService {
    constructor(private http: Http, private config: AppConfig, private tokenstore: TokenStore) { }

    getAll() {
        return this.http.get(this.config.apiUrl + this.config.userEndpoint, this.tokenstore.jwt()).map((response: Response) => response.json());
    }

    getById(id: number) {
        return this.http.get(this.config.apiUrl + this.config.userEndpoint + id, this.tokenstore.jwt()).map((response: Response) => response.json());
    }

    create(user: User) {
        return this.http.post(this.config.apiUrl + this.config.userEndpoint, user, this.tokenstore.jwt());
    }

    update(user: User) {
        return this.http.put(this.config.apiUrl + this.config.userEndpoint + user.id, user, this.tokenstore.jwt());
    }

    delete(id: number) {
        return this.http.delete(this.config.apiUrl + this.config.userEndpoint + id, this.tokenstore.jwt());
    }

}
