import React from 'react';

import signExprVideo from '../../assets/signExpr.mp3';

interface EntrySignVideoProps {
  videoUrl: string;
}

const EntrySignVideo = ({ videoUrl }: EntrySignVideoProps) => {
  return (
    <div>
      <video width="400" controls>
        <source src={signExprVideo} type="video/mp4" />
        Your browser does not support the video tag.
      </video>
    </div>
  );
};

export default EntrySignVideo;
