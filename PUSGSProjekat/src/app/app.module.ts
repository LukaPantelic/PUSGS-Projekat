import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ToastrModule } from 'ngx-toastr';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { ProfileComponent } from './profile/profile.component';
import { IncidentBrowserComponent } from './incident-browser/incident-browser.component';
import { NotificationComponent } from './notification/notification.component';
import { NotificationAllComponent } from './notification/notification-all/notification-all.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { UnregisterGuard } from './guards/unregister.guard';
import { WorkerGuard } from './guards/worker.guard';
import { AuthInterceptor } from './authInterceptor';
import { AddConsumerComponent } from './add-consumer/add-consumer.component';
import { AddDeviceComponent } from './add-device/add-device.component';
import { AddNewDeviceComponent } from './add-new-device/add-new-device.component';
import { AddTeamsComponent } from './add-teams/add-teams.component';
import { SafetyDocumentsComponent } from './safety-documents/safety-documents.component';
import { SafetyDocumentsAddComponent } from './safety-documents-add/safety-documents-add.component';
import { SwitchingPlansComponent } from './switching-plans/switching-plans.component';
import { SwitchingPlansNewComponent } from './switching-plans-new/switching-plans-new.component';
import { SafetyDocumentsBasicInfoComponent } from './safety-documents-add/safety-documents-basic-info/safety-documents-basic-info.component';
import { SafetyDocumentsChecklistComponent } from './safety-documents-add/safety-documents-checklist/safety-documents-checklist.component';
import { SafetyDocumentsEquipmentComponent } from './safety-documents-add/safety-documents-equipment/safety-documents-equipment.component';
import { SafetyDocumentsHistoryComponent } from './safety-documents-add/safety-documents-history/safety-documents-history.component';
import { SafetyDocumentsMultimediaComponent } from './safety-documents-add/safety-documents-multimedia/safety-documents-multimedia.component';
import { IncidentBasicInfoComponent } from './incident-new/basic-information/basic-information.component';
import { IncidentNewComponent } from './incident-new/incident-new.component';
import { IncidentCallsComponent } from './incident-new/incident-calls/incident-calls.component';
import { IncidentCrewComponent } from './incident-new/incident-crew/incident-crew.component';
import { IncidentDevicesComponent } from './incident-new/incident-devices/incident-devices.component';
import { IncidentEquipmentComponent } from './incident-new/incident-equipment/incident-equipment.component';
import { IncidentMultimediaComponent } from './incident-new/incident-multimedia/incident-multimedia.component';
import { IncidentResolutionComponent } from './incident-new/incident-resolution/incident-resolution.component';
import { SwitchingPlansBasicInfoComponent } from './switching-plans-new/switching-plans-basic-info/switching-plans-basic-info.component';
import { SwitchingPlansChecklistComponent } from './switching-plans-new/switching-plans-checklist/switching-plans-checklist.component';
import { SwitchingPlansEquipmentComponent } from './switching-plans-new/switching-plans-equipment/switching-plans-equipment.component';
import { SwitchingPlansHistoryComponent } from './switching-plans-new/switching-plans-history/switching-plans-history.component';
import { SwitchingPlansMultimediaComponent } from './switching-plans-new/switching-plans-multimedia/switching-plans-multimedia.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    LoginComponent,
    RegisterComponent,
    ProfileComponent,
    IncidentBrowserComponent,
    NotificationComponent,
    NotificationAllComponent,
    SidebarComponent,
    AddConsumerComponent,
    AddDeviceComponent,
    AddNewDeviceComponent,
    AddTeamsComponent,
    SafetyDocumentsComponent,
    SafetyDocumentsAddComponent,
    SwitchingPlansComponent,
    SwitchingPlansNewComponent,
    SafetyDocumentsBasicInfoComponent,
    SafetyDocumentsChecklistComponent,
    SafetyDocumentsEquipmentComponent,
    SafetyDocumentsHistoryComponent,
    SafetyDocumentsMultimediaComponent,
    IncidentBasicInfoComponent,
    IncidentNewComponent,
    IncidentCallsComponent,
    IncidentCrewComponent,
    IncidentDevicesComponent,
    IncidentEquipmentComponent,
    IncidentMultimediaComponent,
    IncidentResolutionComponent,
    SwitchingPlansBasicInfoComponent,
    SwitchingPlansChecklistComponent,
    SwitchingPlansEquipmentComponent,
    SwitchingPlansHistoryComponent,
    SwitchingPlansMultimediaComponent
  ],
  imports: [
    HttpClientModule,
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    ToastrModule.forRoot(),

  ],
  providers: [
    UnregisterGuard,
    WorkerGuard,
    { provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true},
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
