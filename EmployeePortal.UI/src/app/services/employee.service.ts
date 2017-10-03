import { Injectable } from '@angular/core';
import { Http, RequestOptions, Response } from '@angular/http';

import { AppConfig } from '../config/index';
import { Employee } from '../models/index';
import { TokenStore } from './token.service';

@Injectable()
export class EmployeeService {
    constructor(private http: Http, private config: AppConfig, private tokenstore: TokenStore) { }

    getAll() {
        return this.http.get(this.config.apiUrl + this.config.employeeEndpoint, this.tokenstore.jwt()).map((response: Response) => response.json());
    }

    getById(id: number) {
        return this.http.get(this.config.apiUrl + this.config.employeeEndpoint + id, this.tokenstore.jwt()).map((response: Response) => response.json());
    }

    create(employee: Employee) {
        return this.http.post(this.config.apiUrl + this.config.employeeEndpoint, employee, this.tokenstore.jwt());
    }

    update(employee: Employee) {
        return this.http.put(this.config.apiUrl + this.config.employeeEndpoint, employee, this.tokenstore.jwt());
    }

    delete(id: number) {
        return this.http.delete(this.config.apiUrl + this.config.employeeEndpoint + id, this.tokenstore.jwt());
    }

}
