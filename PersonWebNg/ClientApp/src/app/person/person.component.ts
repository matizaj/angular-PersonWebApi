import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PersonService} from './../person.service';
import { Person } from './../person';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  person: Person[];
  p1: Person = {id: 33, name: 'stefan'};
  constructor(private personService: PersonService) {
    this.populatePeople();
  }

  ngOnInit() {
  }
  populatePeople() {
      this.personService.getPeople().subscribe(person => this.person = person);
    }
    createPerson(p1) {
      this.personService.addPerson(p1).subscribe(data => { this.populatePeople(); });
    }
}
// add(name: string): void {
//     name = name.trim();
//     if (!name) { return; }
//     this.heroService.addHero({ name } as Hero)
//       .subscribe(hero => {
//         this.heroes.push(hero);
//       });
//   }
