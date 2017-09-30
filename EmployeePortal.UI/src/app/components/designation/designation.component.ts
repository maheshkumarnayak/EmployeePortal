import { Component, OnInit } from '@angular/core';
import { Designation } from '../../models/index';
import { AlertService, DesignationService } from '../../services/index';


@Component({
    moduleId: module.id,
    templateUrl: 'designation.component.html'
})

export class DesignationComponent implements OnInit {
    designations: Designation[] = [];

    constructor(
        private designationService: DesignationService,
        private alertService: AlertService) { }

    ngOnInit() {
        this.loadAllEmployees();
    }

    private loadAllEmployees() {
        this.designationService.getAll().subscribe(degns => { this.designations = degns; });
    }
}
