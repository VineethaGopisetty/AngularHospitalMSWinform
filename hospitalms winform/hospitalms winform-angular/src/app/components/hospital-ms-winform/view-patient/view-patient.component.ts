import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "hospital-ms-winform-view-patient",
   styleUrls : ["./view-patient.component.css"],
   templateUrl : "./view-patient.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmHospitalMS_WinformViewPatient"])
export class ViewPatientComponent extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}