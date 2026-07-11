import type { AUTO_LANGUAGE, SUPPORTED_LANGUAGES } from "./constants";

export type Langauge = keyof typeof SUPPORTED_LANGUAGES;
export type AutoLanguage = typeof AUTO_LANGUAGE;
export type fromLanguage = Langauge | AutoLanguage;

export interface State {
  fromLanguage: fromLanguage;
  toLanguage: Langauge;
  fromText: string;
  result: string;
  loading: boolean;
}

export type Action =
  | { type: "SET_FROM_LANGUAGE"; payload: fromLanguage }
  | { type: "INTERCHANGE_LANGUAGES" }
  | { type: "SET_TO_LANGUAGE"; payload: Langauge }
  | { type: "SET_FROM_TEXT"; payload: string }
  | { type: "SET_RESULT"; payload: string };

export enum SelectType{
  From = 'from',
  To= 'to'
}