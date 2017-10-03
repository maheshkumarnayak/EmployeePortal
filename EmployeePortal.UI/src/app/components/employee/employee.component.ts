import { Component, OnInit } from '@angular/core';
import { Employee } from '../../models/index';
import { AlertService, EmployeeService } from '../../services/index';


@Component({
    moduleId: module.id,
    templateUrl: 'employee.component.html'
})

export class EmployeeComponent implements OnInit {
    employees: Employee[] = [];

    constructor(
        private employeeService: EmployeeService,
        private alertService: AlertService) { }

    ngOnInit() {
        this.loadAllEmployees();
    }

    private loadAllEmployees() {
        this.employeeService.getAll().subscribe(emps => { this.employees = emps; });
    }
}
