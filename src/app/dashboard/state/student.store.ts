import { Injectable } from '@angular/core';
import { Student } from './student.model';
import { EntityState, EntityStore, StoreConfig } from '@datorama/akita';

export interface StudentState extends EntityState<Student> { }

@Injectable({
    providedIn: 'root'
})
@StoreConfig({
    name: 'students'
})
export class StudentStore extends EntityStore<StudentState, Student> {
    createOrReplace(id: import("@datorama/akita").ID, arg1: { id: import("@datorama/akita").ID; name: string; sex: "Male" | "Female"; standard: number; quarterlyScore: number; halfyearlyScore: number; annualScore: number; }) {
      throw new Error("Method not implemented.");
    }
    constructor() {
        super();
    }
}