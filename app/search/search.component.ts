import { Component, OnInit } from '@angular/core';
import { Movie } from '../movie';
import { SearchService } from '../search.service';
@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  listmovie:any;
  obj:any;
  id1:any;
  maname:any;
  ps:any;

  constructor(private serve1:SearchService) { }

  ngOnInit(): void {
    this.getdata();
  }
  getdata(){
    this.serve1.DisplayAll().subscribe(
      data=>{
      this.listmovie=data;
     }
   );
  }
 search(id1:any){
  this.obj=new Movie();
  this.obj.id=id1;
  this.serve1.searchmovie(id1).subscribe(
    ()=>{
      
    }
  )
}
}

