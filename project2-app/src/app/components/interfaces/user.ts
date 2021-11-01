export interface User {
    id: number,
    fullName: string,
    pass: string,
    email: string,
    dateJoined?: string,
    isAdmin?: number
}