export class User {
    id? : number;
    firstname?: string;
    lastname?: String;
    password?: string;
    dateofbirth?: Date;
    email?: string;
    gender?: string;
    
    constructor(args: User={}) {
        this.firstname=args.firstname;
        this.lastname=args.lastname;
        this.dateofbirth=args.dateofbirth;
        this.password=args.password;
        this.email=args.email;
        this.gender=args.gender;
        
    }
}
