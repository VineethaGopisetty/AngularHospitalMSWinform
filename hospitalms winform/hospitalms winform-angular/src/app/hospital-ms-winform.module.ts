
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { WebMapKendoModule } from '@mobilize/winforms-components';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as HospitalMSWinform from './components/hospital-ms-winform';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    WebMapKendoModule,
    WebMapModule,
  ],
  exports: [
    HospitalMSWinform.AboutComponent,
    HospitalMSWinform.HomeComponent,
    HospitalMSWinform.LoginComponent,
    HospitalMSWinform.MainComponent,
    HospitalMSWinform.PatientComponent,
    HospitalMSWinform.SlipComponent,
    HospitalMSWinform.ViewPatientComponent,
  ],
  declarations: [
    HospitalMSWinform.AboutComponent,
    HospitalMSWinform.HomeComponent,
    HospitalMSWinform.LoginComponent,
    HospitalMSWinform.MainComponent,
    HospitalMSWinform.PatientComponent,
    HospitalMSWinform.SlipComponent,
    HospitalMSWinform.ViewPatientComponent,
  ],
  bootstrap: [
    HospitalMSWinform.AboutComponent,
    HospitalMSWinform.HomeComponent,
    HospitalMSWinform.LoginComponent,
    HospitalMSWinform.MainComponent,
    HospitalMSWinform.PatientComponent,
    HospitalMSWinform.SlipComponent,
    HospitalMSWinform.ViewPatientComponent,
  ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class HospitalMSWinformModule { }

