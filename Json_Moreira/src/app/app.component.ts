import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';

@Component({
  standalone: true,
  imports: [CommonModule],  // Asegúrate de que CommonModule esté aquí
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  jsonData: any;
  loading = true;  
  error = '';

  constructor(private http: HttpClient) {
    console.log('Componente cargado');
  }

  ngOnInit(): void {
    const jsonUrl = 'https://drive.google.com/file/d/15d1yVmYfoQlDxB0caf3kmSFHELJsTtO5/view?usp=drive_link';  
    console.log('Iniciando carga de JSON...');
    this.loading = true;

    this.http.get(jsonUrl).subscribe({
      next: (data) => {
        console.log('Datos recibidos:', data); 
        this.jsonData = data;
        this.loading = false;  
        console.log('loading:', this.loading);
      },
      error: (err) => {
        console.error('Error al cargar el JSON', err);
        this.error = 'Error al cargar el JSON';
        this.loading = false;
        console.log('loading:', this.loading); 
      }
    });
  }
}
