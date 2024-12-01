import React from 'react';
import './SignDisplay.css';

import EntrySignVideo from '../EntrySign/EntrySignVideo';
import EntryDescription from '../EntrySign/EntryDescription';
import { Sign } from '../../models/SignModel';

interface SignDisplayProps {
  sign: Sign;
}

const SignDisplay = ({ sign }: SignDisplayProps) => {
  return (
    <div className="entry">
      <EntrySignVideo videoUrl={sign.metaVideoUrl} />
      <EntryDescription
        lingusticData={sign.expression}
        articlesCount={sign.detailSigns.length}
      />
    </div>
  );
};

export default SignDisplay;
