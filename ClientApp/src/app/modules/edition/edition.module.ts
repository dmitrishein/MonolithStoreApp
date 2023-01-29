import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatCardModule} from '@angular/material/card';
import { EditionDetailComponent } from './components/edition-detail/edition-detail.component';
import { EditionPageComponent } from './components/edition-page/edition-page.component';
import { NgxPaginationModule } from 'ngx-pagination';
import { NgxSliderModule } from '@angular-slider/ngx-slider';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { MatCheckboxModule}  from '@angular/material/checkbox';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatIconModule } from '@angular/material/icon';





@NgModule({
  declarations: [
    EditionDetailComponent,
    EditionPageComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    MatGridListModule,
    MatCheckboxModule,
    MatFormFieldModule,
    MatInputModule,
    MatCardModule,
    MatSelectModule,
    NgxPaginationModule,
    NgxSliderModule,
    RouterModule,
    MatIconModule
  ]
})
export class EditionModule { }
