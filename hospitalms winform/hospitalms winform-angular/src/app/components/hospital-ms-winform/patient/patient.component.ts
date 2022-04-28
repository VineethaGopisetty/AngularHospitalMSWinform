import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "hospital-ms-winform-patient",
   styleUrls : ["./patient.component.css"],
   templateUrl : "./patient.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmHospitalMS_WinformPatient"])
export class PatientComponent extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}