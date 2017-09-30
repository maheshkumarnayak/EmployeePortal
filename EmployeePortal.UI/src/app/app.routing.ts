import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './components/home/index';
import { LoginComponent } from './components/login/index';
import { RegisterComponent } from './components/register/index';
import { EmployeeComponent } from './components/employee/index';
import { DesignationComponent } from './components/designation/index';
import { AuthGuard } from './guards/index';

const appRoutes: Routes = [
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
    { path: 'home', component: HomeComponent, canActivate: [AuthGuard] },
    { path: '', redirectTo: '/home', pathMatch:'full'},
    { path: 'employee', component: EmployeeComponent, canActivate:[AuthGuard] },
    { path: 'designation', component: DesignationComponent, canActivate:[AuthGuard] },

    // otherwise redirect to home
    { path: '**', redirectTo: '' }
];

export const routing = RouterModule.forRoot(appRoutes);
