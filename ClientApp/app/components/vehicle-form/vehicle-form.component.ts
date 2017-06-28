import { MakeService } from './../../services/make.service';
import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'VehicleFormComponent',
    templateUrl: './vehicle-form.component.html',
})

export class VehicleFormComponent implements OnInit {
    makes;
    constructor(private makeService: MakeService) { }
    ngOnInit() {
        this.makeService.getMakes().subscribe(makes => {
            this.makes = makes;
            console.log("MAKES", this.makes);
        });
        
    }
}