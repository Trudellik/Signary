import {
  HandshapeTypes,
  HandsUsageTypes,
  MouthingTypes,
  MovementTypes,
} from './Types';

export interface Sign {
  id: string;
  metaVideoUrl: string;
  expression: LingusticDefinition;
  detailSigns: DetailSign[];
}

export interface DetailSign {
  id: string;
  videoUrl: string;
  definitionVideoUrl: string;
  mouthing: MouthingDefiniton;
}

export interface LingusticDefinition {
  handshape: HandshapeTypes;
  handsusage: HandsUsageTypes;
  movement: MovementTypes;
}

export interface MouthingDefiniton {
  mouthingType: MouthingTypes;
  mouthingExpression: string;
}
