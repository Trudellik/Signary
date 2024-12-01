import { Sign } from '../models/SignModel';

export const mockSigns: Sign[] = [
  {
    id: 'sign1',
    metaVideoUrl: 'https://example.com/video1',
    expression: {
      handshape: 'b',
      handsusage: 'mirror',
      movement: 'oneMovement',
    },
    detailSigns: [
      {
        id: 'detail1',
        videoUrl: 'https://example.com/detail1-video',
        definitionVideoUrl: 'https://example.com/detail1-definition',
        mouthing: {
          mouthingType: 'describing',
          mouthingExpression: 'example expression for detail1',
        },
      },
      {
        id: 'detail2',
        videoUrl: 'https://example.com/detail2-video',
        definitionVideoUrl: 'https://example.com/detail2-definition',
        mouthing: {
          mouthingType: 'wording',
          mouthingExpression: 'example expression for detail2',
        },
      },
    ],
  },
  {
    id: 'sign2',
    metaVideoUrl: 'https://example.com/video2',
    expression: {
      handshape: 'fly',
      handsusage: 'async',
      movement: 'repeatMovement',
    },
    detailSigns: [
      {
        id: 'detail1',
        videoUrl: 'https://example.com/detail1-video',
        definitionVideoUrl: 'https://example.com/detail1-definition',
        mouthing: {
          mouthingType: 'describing',
          mouthingExpression: 'example expression for detail1',
        },
      },
      {
        id: 'detail2',
        videoUrl: 'https://example.com/detail2-video',
        definitionVideoUrl: 'https://example.com/detail2-definition',
        mouthing: {
          mouthingType: 'wording',
          mouthingExpression: 'example expression for detail2',
        },
      },
    ],
  },
  {
    id: 'sign4',
    metaVideoUrl: 'https://example.com/video4',
    expression: {
      handshape: 'pege',
      handsusage: 'solo',
      movement: 'still',
    },
    detailSigns: [
      {
        id: 'detail1',
        videoUrl: 'https://example.com/detail1-video',
        definitionVideoUrl: 'https://example.com/detail1-definition',
        mouthing: {
          mouthingType: 'describing',
          mouthingExpression: 'example expression for detail1',
        },
      },
      {
        id: 'detail2',
        videoUrl: 'https://example.com/detail2-video',
        definitionVideoUrl: 'https://example.com/detail2-definition',
        mouthing: {
          mouthingType: 'wording',
          mouthingExpression: 'example expression for detail2',
        },
      },
    ],
  },
  {
    id: 'sign6',
    metaVideoUrl: 'https://example.com/video6',
    expression: {
      handshape: 'b',
      handsusage: 'super-sub',
      movement: 'round',
    },
    detailSigns: [
      {
        id: 'detail1',
        videoUrl: 'https://example.com/detail1-video',
        definitionVideoUrl: 'https://example.com/detail1-definition',
        mouthing: {
          mouthingType: 'describing',
          mouthingExpression: 'example expression for detail1',
        },
      },
      {
        id: 'detail2',
        videoUrl: 'https://example.com/detail2-video',
        definitionVideoUrl: 'https://example.com/detail2-definition',
        mouthing: {
          mouthingType: 'wording',
          mouthingExpression: 'example expression for detail2',
        },
      },
    ],
  },
  {
    id: 'sign8',
    metaVideoUrl: 'https://example.com/video8',
    expression: {
      handshape: 'fly',
      handsusage: 'mirror',
      movement: 'oneMovement',
    },
    detailSigns: [
      {
        id: 'detail1',
        videoUrl: 'https://example.com/detail1-video',
        definitionVideoUrl: 'https://example.com/detail1-definition',
        mouthing: {
          mouthingType: 'describing',
          mouthingExpression: 'example expression for detail1',
        },
      },
      {
        id: 'detail2',
        videoUrl: 'https://example.com/detail2-video',
        definitionVideoUrl: 'https://example.com/detail2-definition',
        mouthing: {
          mouthingType: 'wording',
          mouthingExpression: 'example expression for detail2',
        },
      },
    ],
  },
  {
    id: 'sign10',
    metaVideoUrl: 'https://example.com/video10',
    expression: {
      handshape: 'pege',
      handsusage: 'async',
      movement: 'repeatMovement',
    },
    detailSigns: [
      {
        id: 'detail1',
        videoUrl: 'https://example.com/detail1-video',
        definitionVideoUrl: 'https://example.com/detail1-definition',
        mouthing: {
          mouthingType: 'describing',
          mouthingExpression: 'example expression for detail1',
        },
      },
      {
        id: 'detail2',
        videoUrl: 'https://example.com/detail2-video',
        definitionVideoUrl: 'https://example.com/detail2-definition',
        mouthing: {
          mouthingType: 'wording',
          mouthingExpression: 'example expression for detail2',
        },
      },
    ],
  },
];
