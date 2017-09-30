import { Injectable } from '@angular/core';
import { Http, RequestOptions, Response } from '@angular/http';

import { AppConfig } from '../config/index';
import { Designation } from '../models/index';
import { TokenStore } from './token.service';

@Injectable()
export class DesignationService {
    constructor(private http: Http, private config: AppConfig, private tokenstore: TokenStore) { }

    getAll() {
        return this.http.get(this.config.apiUrl + this.config.designationEndpoint, this.tokenstore.jwt()).map((response: Response) => response.json());
    }

    getById(id: number) {
        return this.http.get(this.config.apiUrl + this.config.designationEndpoint + id, this.tokenstore.jwt()).map((response: Response) => response.json());
    }

    create(designation: Designation) {
        return this.http.post(this.config.apiUrl + this.config.designationEndpoint, designation, this.tokenstore.jwt());
    }

    update(designation: Designation) {
        return this.http.put(this.config.apiUrl + this.config.designationEndpoint, designation, this.tokenstore.jwt());
    }

    delete(id: number) {
        return this.http.delete(this.config.apiUrl + this.config.designationEndpoint + id, this.tokenstore.jwt());
    }

}
