export class User {
    Id? : number;
    FirstName?: string;
    LastName?: String;
    Password?: string;
    DateOfBirth?: Date;
    Email?: string;
    Gender?: string;
    
    constructor(args: User={}) {
        this.FirstName=args.FirstName;
        this.LastName=args.LastName;
        this.DateOfBirth=args.DateOfBirth;
        this.Password=args.Password;
        this.Email=args.Email;
        this.Gender=args.Gender;
        
    }
}
