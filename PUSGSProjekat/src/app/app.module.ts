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
    SafetyDocumentsMultimediaComponent
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
