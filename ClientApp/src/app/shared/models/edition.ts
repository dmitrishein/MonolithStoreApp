export interface Edition {
    id:number;
    title :string;
    description :string;
    price : number;
    currency : string;
    status : string;
    type : string; 
    authors : Author[];
}

export class EditionPageParameters{
    ElementsPerPage !: number;
    CurrentPageNumber !: number;
    SearchString !: string;
    MaxUserPrice !: number;
    MinUserPrice !: number;
    EditionTypes !: number[];
    SortType !: number;
    IsReversed !: boolean;
    constructor(){};
}

export interface EditionPageResponseModel{
    MaxPrice : number,
    MinPrice : number,
    TotalItemsAmount : number;
    CurrentPage : number;
    Editions : Edition[];
}

export interface Author {
    id:number;
    name:string;
}